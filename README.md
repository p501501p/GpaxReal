# GpaxCalculator

![image](https://github.com/user-attachments/assets/88a221ca-7b9a-4188-9558-fe7ae990d841)

 

โค้ดนี้เป็น C# class สำหรับคำนวณค่า GPAX (เกรดเฉลี่ยสะสม) โดยมีคุณสมบัติดังนี้:

1. ตัวแปรในคลาส
gpa_sum → เก็บผลรวมของค่า GPA ที่ป้อนเข้ามา
n → นับจำนวนครั้งที่มีการป้อน GPA
max → เก็บค่า GPA ที่มากที่สุด
min → เก็บค่า GPA ที่น้อยที่สุด
2. เมธอดในคลาส
setGPA(double gpa) → รับค่า GPA ใหม่เข้ามา แล้ว

เพิ่มค่า GPA ลงใน gpa_sum
เพิ่มค่าตัวนับ n
อัปเดตค่ามากสุด (max) และน้อยสุด (min)
getGPAX() → คำนวณ GPAX โดยใช้สูตร

GPAX
=
ผลรวมของ GPA ทั้งหมด
จำนวนครั้งที่ป้อนค่า
GPAX= 
จำนวนครั้งที่ป้อนค่า
ผลรวมของ GPA ทั้งหมด
​
 
แล้วปัดเศษให้มีทศนิยม 2 ตำแหน่ง

getmax() → คืนค่า GPA ที่มากที่สุด

getmin() → คืนค่า GPA ที่น้อยที่สุด

getPeople() → คืนค่าจำนวนครั้งที่ป้อน GPA
