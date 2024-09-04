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
MVC servisleri, uygulamanızın model, view ve controller bileşenlerini kullanabilmesi için gerekli yapılandırmaları sağlar.


Statik Dosyaların Kullanımının Belirtilmesi
-
Statik dosyaların kullanımının belirtilmesi, CSS, JavaScript ve resim dosyalarının wwwroot klasöründen sunulmasını sağlar.

Routing Konfigürasyonu
-
 Routing konfigürasyonu, tarayıcıdan gelen istekleri doğru controller ve aksiyonlara yönlendirerek uygulamanızın yönlendirme işlemlerini yönetir.


Varsayılan Routing
-
Varsayılan routing, uygulamanızın ana sayfasına yönlendirilmesi için belirli bir controller ve aksiyonu varsayılan olarak ayarlar.


Özet
-
Bu yapılandırmaları tamamladıktan sonra, projeniz MVC yapısına uygun olarak çalışmaya hazır olacaktır. Controllers klasöründe controller'larınızı, Models klasöründe model sınıflarınızı, Views klasöründe ise view'lerinizi oluşturabilirsiniz. wwwroot klasöründe ise CSS, JavaScript ve diğer statik dosyalarınızı barındırabilirsiniz.

Uygulamanızı başlattığınızda, varsayılan routing yapılandırması ile belirlediğiniz controller'ın ana aksiyonu ana sayfanız olarak görüntülenecektir.

