namespace piedteam_net1_2_hocmienphi.repository;

public class Class1
{
}
//CODE FIRST || DATABASE FIRST
//ORM

//Thông thường để mà trên code có thể làm việc được với Database,
    //Thì mình cần phải ánh xạ (mapping) từ các table lên code để
    //dễ dàng thao tác với dữ liệu.
    
//Database First:
//Mình làm việc với 1 Database đã có sẵn,(Create Database bằng SQL)
//Vô tạo database nè, set up các field, các relationship, constraint trong DB
//Sau đó ở trên code sử dụng các Driver hoặc thư viện ORM để kết nối xuống Database
//Thằng này sử dụng khi nào: Khi database đã có sẵn và đang được sử dụng 
    //trong nhiều năm. Được join vào dự án Maintain

//Code First: 
//Mnh sẽ không se up DB thủ công bằng các câu lệnh query
//create database, create constraint,
//mình sẽ Design Databse bằng các class trên Code, trên Code set up như thế nào
    //thì Database sẽ được tạo ra như thế đó
    //Mình set up trên code các field, các relationship
    //Sau đó mình ánh xạ các đoạn code đó để tạo ra các table trong database
//Vậy thì làm thế nào để ánh xạ được từ code xuống các table trong database 
    //Câu trả lời:ORM - Object Rrlational Mapping - Enti
    //Nó sẽ là thằng trung gian đứng giữa làm nhiều thứ
        //Nó sẽ đọc class trên code, đọc các attribute, đọc các cấu hinhg
        //sau đó tạo ra các câu lệnh SQL đê tạo ra các bảng
        //Nó cũng là thằng kết hợp với LINQ
        //khi sử dụng các hàm Where..., Translate sang SQL
        //- WHERE() => Select * from table where ...
    //Thằng này được sử dụng khi
//Mình mới bắt đầu dự án, chưa có Database nào cẩ
//Thiết kế bằng Code thì nó sẽ dễ dàng Maintain (Dễ nhìn,
//dễ sửa đổi) hơn so với các câu lệnh SQL

//Nếu mà không biết về LINQ + EF thì coi như mất 95% sức mạnh

