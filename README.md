## ความเป็นมา และ วัตถุประสงค์
ความเป็นมา : อยากทำระบบจัดการสินค้าแบบง่ายๆขึ้นมา
วัตถุประสงค์ : ลงทะเบียนสินค้า หมวดหมู่ และจำนวนของสินค้าที่อยากลง



## ผู้เขียน
Name : เนติธร ศรีมี
id : 653450292-4
e-mail : natithorn.s@kkumail.com


## classDiagram

```mermaid
classDiagram
ResourceInfo --|> Resource 
<<Interface>> ResourceInfo
Class09 --> C2 : Where am i?
Class09 --* C3
Class09 --|> Class07
Class07 : equals()
Class07 : Object[] elementData
ResourceInfo : str DataGirds
class Class10 {
  <<service>>
  int id
  size()
}
```

