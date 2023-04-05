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

class1 --|> ResourceInfo
ResourceInfo : DataGrids
ResourceInfo : File.Open
ResourceInfo : File.Save
ResourceInfo : NewItem

ResourceInfo --|> Resource
Resource --|> ResourceInfo
class1 --|> Resource
Resource : Form add product
class1 Product {
  <<Class>>
  str name
  str category
  int Number
}

```

