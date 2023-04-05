ความเป็นมา : อยากทำระบบจัดการสินค้าแบบง่ายๆขึ้นมา
วัตถุประสงค์ : ลงทะเบียนสินค้า หมวดหมู่ และจำนวนของสินค้าที่อยากลง




Name : เนติธร ศรีมี
id : 653450292-4
e-mail : natithorn.s@kkumail.com


---
title: Animal example
---
classDiagram
    note "From Duck till Zebra"
    Animal <|-- Duck
    note for Duck "can fly\ncan swim\ncan dive\ncan help in debugging"
    Animal <|-- Fish
    Animal <|-- Zebra
    Animal : +int age
    Animal : +String gender
    Animal: +isMammal()
    Animal: +mate()
    class Duck{
        +String beakColor
        +swim()
        +quack()
    }
    class Fish{
        -int sizeInFeet
        -canEat()
    }
    class Zebra{
        +bool is_wild
        +run()
    }

