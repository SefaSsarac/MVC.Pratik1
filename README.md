ASP.NET CORE MVC PROJESİ
-
Bu rehber, ASP.NET Core Empty projesinde MVC tasarım desenine uygun yapıları nasıl ekleyip yapılandıracağınızı açıklar.

Proje Yapılandırması
-

Klasörlerin Oluşturulması
-
Projenizin kök dizininde aşağıdaki klasörleri oluşturun:

Controllers:
-
MVC Controller'larınızı içerecek.
Models:
-
Uygulamanızın veri yapıları ve iş mantığını içerecek.
Views:
-
Kullanıcı arayüzü şablonlarını içerecek.
wwwroot:
-
Statik dosyalar (CSS, JavaScript, resimler vb.) için kullanılacak.



MVC Servislerinin Eklenmesi
-


Statik Dosyaların Kullanımının Belirtilmesi
-


Routing Konfigürasyonu
-


Varsayılan Routing
-


Özet
-
Bu yapılandırmaları tamamladıktan sonra, projeniz MVC yapısına uygun olarak çalışmaya hazır olacaktır. Controllers klasöründe controller'larınızı, Models klasöründe model sınıflarınızı, Views klasöründe ise view'lerinizi oluşturabilirsiniz. wwwroot klasöründe ise CSS, JavaScript ve diğer statik dosyalarınızı barındırabilirsiniz.

Uygulamanızı başlattığınızda, varsayılan routing yapılandırması ile belirlediğiniz controller'ın ana aksiyonu ana sayfanız olarak görüntülenecektir.

