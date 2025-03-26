# SignalR Restoran Yönetim Projesi
![project](https://github.com/user-attachments/assets/56f260b8-ed37-4059-8e94-e3f182b080bf)

## Proje Açıklaması
Hamburgercim, bir restoran senaryosu üzerinde rezervasyon ve sipariş süreçlerinin kolayca yönetilebilmesi için geliştirilmiş bir sistemdir. Kullanıcılar, restorana giriş yaparak menüdeki ürünleri inceleyebilir, sepetlerine ekleyebilir ve masaya sipariş verebilirler. Ayrıca kullanıcılar rezervasyon oluşturma, mesaj gönderme imkânına da sahip.

Admin panelinde, SignalR ullanılarak siparişler, rezervasyonlar ve mesajlar gerçek zamanlı olarak görüntülenebilir. Bu sayede yöneticiler; anlık olarak masalara yapılan siparişleri tamamlayabilir ve çeşitli istatistiksel verileri inceleyebilir. Bununla beraber sitenin ön yüz kısmındaki verileri büyük ölçüde admin paneliyle dinamik olarak özelleştirmek mümkün.
## Teknik Detaylar
Bu proje ASP.NET Core 6.0 ve SignalR kullanılarak geliştirildi. Tüm CRUD işlemleri API katmanı üzerinden gerçekleştirildi ve MVC tarafında dinamik bir yapıya entegre edildi. Veritabanı olarak MSSQL Server üzerinde Code-First olarak Entity Framework Core kullanıldı. 

Proje, sürdürülebilirlik ve modülerlik açısından N katmanlı mimariye (Entity, DataAccess, Business, DTO, API, UI) ve SOLID prensiplerine uygun olarak geliştirildi. Bu açıdan CRUD işlemlerini merkezileştirmek için Generic Repository tasarım deseni uygulandı. 
## Kullanılan Teknolojiler
<ul>
  <li>ASP.NET Core 6.0</li>
  <li>ASP.NET Core Web API</li>
   <li>SignalR</li>
   <li>Entity Framework Code First</li>
   <li>MSSQL Server</li>
   <li>Identity</li>
   <li>Fluent Validation</li>
  <li>AutoMapper</li>
    <li>QRCoder</li>
  
    <li>HTML, CSS, JavaScript</li>
    <li>Bootstrap</li>
    <li>Ajax</li>
</ul>

## Proje Görselleri


### UI
![localhost_7212_Default_Index (1)](https://github.com/user-attachments/assets/cc219a9b-c2f8-4ff1-be1b-9b9871c5fb1e)

### Login
![image](https://github.com/user-attachments/assets/e93171e2-7a32-4999-a270-9b3119ab83b8)
### Register
![image](https://github.com/user-attachments/assets/089bc45f-4fa6-425f-a62c-346b97d2de7a)

### Admin
![image](https://github.com/user-attachments/assets/73786f50-a9ca-41ec-93c7-5c802fc749b7)
![image](https://github.com/user-attachments/assets/fbc53802-4a81-4ea9-bc3b-59d0f861108a)
![image](https://github.com/user-attachments/assets/ee98e5cf-1c60-4e16-a855-7dd4a8bcd950)
![image](https://github.com/user-attachments/assets/932de074-bb84-4ba2-ab9c-ccea2a6a5bbb)
![image](https://github.com/user-attachments/assets/b08847dd-ef26-42e8-af28-37a97e5a9606)

### API
![image](https://github.com/user-attachments/assets/f67a23af-275a-4049-879b-343fb39a5d19)

