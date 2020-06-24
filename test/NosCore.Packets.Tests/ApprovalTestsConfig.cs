//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using ApprovalTests.Reporters;

[assembly: UseReporter(typeof(DiffReporter))]
[assembly: ApprovalTests.Namers.UseApprovalSubdirectory("../../documentation")] 