//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets
{
    public abstract class PacketBase : IPacket
    {
        public string? Header { get; set; }

        public ushort? KeepAliveId { get; set; }

        private readonly List<ValidationResult> _validationResult = new ();
        public List<ValidationResult> ValidationResult
        {
            get
            {
                if (_validationResult.Count == 0)
                {
                    var _ = IsValid;
                }

                return _validationResult;
            }
        }

        public bool IsValid
        {
            get
            {
                var vc = new ValidationContext(this);
                foreach (var prop in GetType().GetProperties()
                             .Where(x=> !typeof(PacketBase).GetProperties().Select(o=>o.Name).Contains(x.Name)))
                {
                    var value = prop.GetValue(this);
                    if (prop.PropertyType.IsEnum && value != null && !Enum.IsDefined(prop.PropertyType, value))
                    {
                        _validationResult.Add(new ValidationResult("Invalid Enum value",
                            new[] { prop.Name }));
                    }

                    var nullabilityContext = new NullabilityInfoContext();
                    var nullabilityInfo = nullabilityContext.Create(prop);
                    if (nullabilityInfo.WriteState is not NullabilityState.Nullable)
                    {
                        var attr = new RequiredAttribute();
                        var result = attr.GetValidationResult(value, vc);
                        if (result != null)
                        {
                            _validationResult.Add(result);
                        }
                    }
                }

                Validator.TryValidateObject(this, vc, _validationResult, true);
                return !_validationResult.Any();
            }
        }
    }
}