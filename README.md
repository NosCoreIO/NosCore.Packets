| Type    | string to serialize | Null | True | False | Value     | Value when Last |
|---------|---------------------|------|------|-------|-----------|-----------------|
| String  | some text           | -    | N/A  | N/A   | some^text | some text       |
| Boolean | true/false          | -1   | 1    | 0     | N/A       | N/A             |
| Number  | 1                   | -1   | N/A  | N/A   | 1         | 1               |
| IPacket | N/A                 | N/A  | N/A  | N/A   | N/A       | N/A             |

| Condition                                         | IPacket splitter | Item splitter | Property splitter | Discriminator    |
|---------------------------------------------------|------------------|---------------|-------------------|------------------|
| contain IPacket properties with a PacketHeader    | space            | space         | ^                 | #                |
| contain IPacket properties without a PacketHeader | space            | space         | space             | no discriminator |
| contain a Host property                           | :                | true/false    | -1                | no discriminator |
| contain a List of IPacket the property            | space            | space         | .                 | no discriminator |