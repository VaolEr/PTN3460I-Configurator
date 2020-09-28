# PTN3460I-Configurator
Readme in progress...

This software is part of a project developed by
for testing various matrices for compatibility with the PTN3460/I chip.

Since there is a need to use the above chip from NXP with
using various matrices, I developed a printed circuit Board on my own to conduct the necessary tests.
A screenshot of the Board is shown below.

![alt text](screenshots/DP-eDP-to-LVDS-board.png "View of designed PCB.")

The Board provides the following operating modes:
1. Manual configuration, by setting the jumpers to the "high" or "low" state;
2. Configuration of PTN3460/I without writing to EEPROM;
3. PTN3460/I configuration with EEPROM entry;
4. As an EEPROM programmer for products developed on the basis of PTN3460/I;
5. You can use it to control the illumination brightness of the matrix under test;
6. You Can use it to enable or disable the matrix.

More details can be found in the video at the link [MyVideo].
[MyVideo]: //https://youtu.be/_daPMuKV2iI/ "Demonstration video"


This Board has an STM32 controller installed (firmware for it via the link), which is used as
USB HID devices for exchanging information between the Host and the device,
and also as a software Configurator for the PTN3460/I chip.

The program interface is shown in the screenshots below.

![alt text](screenshots/PTN3460I-Configurator-1.png "App screenshot 1")
![alt text](screenshots/PTN3460I-Configurator-2.png "App screenshot 2")

