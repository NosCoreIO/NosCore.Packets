# ChickenAPI.Packets (C#)

<center><img src="docs/_media/logo.png"></img>

[![NuGet](https://img.shields.io/nuget/v/ChickenAPI.Packets.svg?style=flat-square)](https://www.nuget.org/packages/ChickenAPI.Packets/)
[![CircleCI](https://circleci.com/gh/ChickenAPI/ChickenAPI.Packets/tree/master.svg?style=svg)](https://circleci.com/gh/ChickenAPI/ChickenAPI.Packets/tree/master)
</center>

## Links
Discord : https://discord.gg/7sTFU8d


## Description

ChickenAPI is an Emulator API for the game Nostale.

We are willing to provide quality API with a lot of things inside it to facilitate and fasten developers' work inside their own projects related to Nostale.

ChickenAPI.Packets is a library including all Nostale packets (at least the ones we have written over so far)


## Knowledge

This is what we know so far about packet serialization of nostale


### PacketIndex serialization by type
| Type    | string to serialize | Null | True | False | Value     | Value when Last |
|---------|---------------------|------|------|-------|-----------|-----------------|
| String  | some text           | -    | N/A  | N/A   | some^text | some text       |
| Boolean | true/false          | -1   | 1    | 0     | N/A       | N/A             |
| Number  | 1                   | -1   | N/A  | N/A   | 1         | 1               |
| IPacket | N/A                 | N/A  | N/A  | N/A   | N/A       | N/A             |


### PacketIndex serialization by condition
| Condition                                         | IPacket splitter | Property splitter | Discriminator    |
|---------------------------------------------------|------------------|-------------------|------------------|
| contain IPacket properties with a PacketHeader    | space            | ^                 | #                |
| contain IPacket properties without a PacketHeader | space            | space             | no discriminator |
| contain a Host property                           | :                | -1                | no discriminator |
| contain a List of IPacket the property            | space            | .                 | no discriminator |