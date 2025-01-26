Proje Hakkında
Bu proje, bir teknoloji mağazasında Telefon ve Bilgisayar ürünlerinin kayıtlarını yönetmek için geliştirilmiştir. Proje, nesne yönelimli programlama (OOP) ilkelerine uygun olarak Kalıtım (Inheritance), Kapsülleme (Encapsulation), Çok Biçimlilik (Polymorphism), Soyutlama (Abstraction) prensipleri ile oluşturulmuştur.

Özellikler
Telefon ve Bilgisayar sınıfları, ortak özelliklerini BaseMakine sınıfından miras alır.
Üretim tarihi, nesne oluşturulduğunda otomatik atanır.
Bilgisayar sınıfında USB giriş sayısı yalnızca 2 veya 4 olabilir, aksi durumda -1 atanır ve uyarı verilir.
BaseMakine sınıfında ortak bilgileri yazdıran bir metot bulunur ve her alt sınıfta özelleştirilmiştir.
Soyut metot sayesinde her ürün tipi için özel ad formatı sağlanmaktadır.
Kullanıcı, konsoldan giriş yaparak ürün ekleyebilir ve görüntüleyebilir.
Kullanım
Konsol ekranında:

Telefon üretmek için 1
Bilgisayar üretmek için 2 tuşlanır.
Kullanıcının seçimine göre ilgili ürün için gerekli bilgiler girilir.

Ürün başarıyla oluşturulduktan sonra bilgiler ekrana yazdırılır.

Kullanıcıya başka bir ürün eklemek isteyip istemediği sorulur.

E girilirse yeni bir ürün eklenebilir.
H girilirse program sonlandırılır.
Sistem Gereksinimleri
.NET Core veya .NET Framework yüklü olmalıdır.
C# programlama dili destekleyen bir IDE (Visual Studio, VS Code vb.)
