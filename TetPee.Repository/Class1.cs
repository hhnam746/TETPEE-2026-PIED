namespace TetPee.Repository;

public class Class1
{
    //ORM: Object relational mapping
    
    
        //Thông thường ở trên code để có thể làm việc với db thí mình cần ánh xạ cac2 table từ DB lên code để dễ
        //quản lí và làm việc
    //Database First :
    // - làm 1 db có sẵn, setup 1 database
    // - vô tạo Create Table, Create Db, set up field và các relationship
    // - sau đó ở trên code sử dụng các driver hoặc ORM để kết nối xuống Database
    // - ở trên code sẽ tạo các class tương ứng với table trên database
    // - Thằng này sử dụng khi nào: Khi mình có DB sẵn và đã sử dụng trong rất nhiều năm ròi để Maintain
    
    //Code First
    // - Mình sẽ không set up DB thủ công bằng các query
    // - Không có Create Table, Create DB, set up field và các relationship
    // - Mình design database bằng những class trên code, trên code set up các entity, field, relation ship
    // - Sau đó ánh xạ từ các class xuống các table trong DB
    // Vậy làm sao để ánh xạ được từ các class trên code xuống DB sử dụng ORM
    // - Thằng này sử dụng khi: dự án mới hiện đại, nhiều công cụ hỗ trợ 
    
    // - Tuyệt đỉnh ORM của .NET: Entity Framework. Không biết sử dụng thành thục thằng này thì mất 90% sức mạnh .NET
   
}