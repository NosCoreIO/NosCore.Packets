# NosCore.Packets #
[forked from ChickenAPI/ChickenAPI.Packets](https://github.com/ChickenAPI/ChickenAPI.Packets)

<p align="center">
  <img width="250px" src="https://github.com/NosCoreIO/NosCore.Packets/blob/15.0.1/icon.png?raw=true"/>
  <img src="docs/_media/logo.png"></img>
</p>

[![NuGet](https://img.shields.io/nuget/v/NosCore.Packets.svg?style=flat-square)](https://www.nuget.org/packages/NosCore.Packets/)
[![.NET](https://github.com/NosCoreIO/NosCore.Packets/actions/workflows/dotnet.yml/badge.svg?branch=master)](https://github.com/NosCoreIO/NosCore.Packets/actions/workflows/dotnet.yml)

# Special Thanks for Contributions #
<p align="left">
<a href="https://aws.amazon.com"><img height="100px" src="https://chiefit.me/wp-content/uploads/2019/06/Amazon-Web-Services_logo835x396.png"/></a>
<a href="https://www.navicat.com"><img height="100px" src="https://i.ibb.co/kx9WJgv/Navicat-Premium.png"/></a>
<a href="https://www.jetbrains.com"><img height="100px" src="https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/JetBrains_Logo_2016.svg/1200px-JetBrains_Logo_2016.svg.png"/></a>
</p>

## You like our work ? ##
<a href='https://github.com/sponsors/0Lucifer0' target='_blank'><img height='48' style='border:0px;height:46px;' src='https://i.gyazo.com/47b2ca2eb6e1ce38d02b04c410e1c82a.png' border='0' alt='Sponsor me!' /></a>
<a href='https://ko-fi.com/A3562BQV' target='_blank'><img height='46' style='border:0px;height:46px;' src='https://az743702.vo.msecnd.net/cdn/kofi3.png?v=0' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a> 
<a href='https://www.patreon.com/bePatron?u=6503887' target='_blank'><img height='46' style='border:0px;height:46px;' src='https://c5.patreon.com/external/logo/become_a_patron_button@2x.png' border='0' alt='Become a Patron!' /></a>

## Achtung! ##
We are not responsible of any damages caused by bad usage of our source. Please before asking questions or installing this source read this readme and also do a research, google is your friend. If you mess up when installing our source because you didnt follow it, we will laugh at you. A lot.

## Instructions to contribute ##

### Disclaimer ###
This project not for commercial use.

## Disclaimer ##
This project is a community project not for commercial use. The result is to learn and program together for prove the study. 

## Legal ##
This is an independent and unofficial server for educational use ONLY. Using the Project might be against the TOS.

### Contribution is only possible with Visual Studio 2019 ###
We recommend usage of : 
* [Roslynator extension](https://github.com/JosefPihrt/Roslynator).
* [Resharper](https://www.jetbrains.com/resharper/)

## Links
[List of Packets](./documentation/DocumentationTest.PacketsDocumentation.approved.md)

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

