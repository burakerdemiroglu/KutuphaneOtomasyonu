# Kütüphane Otomasyonu

Kütüphane Otomasyonu, bir kütüphane yönetim sistemi olarak tasarlanmış ve DevExpress araç takımıyla geliştirilmiş bir uygulamadır. Bu uygulama, kullanıcıların kütüphanedeki kitapları arama, ödünç alma, iade etme ve diğer ilgili işlemleri yönetmelerine olanak tanır. Ayrıca kütüphane personelinin kitap kayıtlarını, stok takibini ve kullanıcı bilgilerini DevExpress'in sağladığı gelişmiş araçlarla kolayca yönetmelerine yardımcı olur.

## Teknolojiler ve Framework'ler

Uygulama aşağıdaki teknolojiler ve framework'ler kullanılarak geliştirilmiştir:

- .NET Framework 4.6.1
- Windows Forms App (.NET Framework)
- DevExpress

## Özellikler

Kütüphane Otomasyonu, DevExpress araç takımının sunduğu özellikleri kullanarak aşağıdaki işlevleri sağlar:

- Üye İşlemleri:
  - Üye listesini görüntüleme ve düzenleme (DevExpress Grid Control kullanarak)
  - Yeni üye kaydı oluşturma (DevExpress Textbox ve Button gibi kontroller kullanarak)
  - Üye arama işlemleri (DevExpress Search Control ile)

- Kitap İşlemleri:
  - Kitap listesini görüntüleme ve düzenleme (DevExpress Grid Control kullanarak)
  - Yeni kitap kaydı oluşturma (DevExpress Textbox ve Button gibi kontroller kullanarak)
  - Kitap arama işlemleri (DevExpress Search Control ile)

- Ödünç Alma ve İade İşlemleri:
  - Ödünç alınan kitapları görüntüleme ve düzenleme (DevExpress Grid Control ve ComboBox kullanarak)
  - Ödünç alma ve iade tarihlerini seçme (DevExpress DateEdit ile)

- Stok Takibi:
  - Kitap stoklarını görüntüleme ve güncelleme (DevExpress Grid Control ve Label gibi kontroller kullanarak)

- Raporlama:
  - Kütüphane istatistiklerini ve ödünç alınan kitap raporlarını oluşturma (DevExpress XtraReport araçlarıyla)

## Kurulum

1. Repoyu klonlayın: `git clone https://github.com/burakerdemiroglu/KutuphaneOtomasyonu.git`
2. Visual Studio IDE'sini açın.
3. Proje dosyasını Visual Studio'da açın.
4. Gerekli NuGet paketlerini yükleyin.
5. Projeyi derleyin ve çalıştırın.

## Kullanım

1. Uygulama başlatıldığında ana form açılır.
2. Ana form üzerindeki menülerden ilgili işlemi seçin ve gerekli bilgileri girin.
3. Üye işlemleri, kitap işlemleri, ödünç alma ve iade işlemleri gibi işlemleri gerçekleştirebilirsiniz.
4. Raporlama bölümünde istatistik ve raporları görüntüleyebilirsiniz.

## Formlar
Bu proje, kütüphane işlemlerini yönetmek amacıyla geliştirilmiştir. Toplamda 10 adet form içermektedir. 

### 1. FrmAnaForm:
   - Sistemin ana formatını içerir.
   - İşlemler 4 ana başlık altında gruplandırılmıştır:
     - Üye İşlemleri: Üye ekleme ve üye listeleme işlemleri.
     - Emanet Kitap Verme İşlemleri: Emanet kitap verme, listeleme ve iade işlemleri.
     - Kitap İşlemleri: Kitap ekleme ve kitap listeleme işlemleri.
     - Sıralama ve Grafikler: Kitap okuyan kişilerin sıralaması ve grafik işlemleri.

<p align="center"> 
   <img src="https://github.com/burakerdemiroglu/KutuphaneOtomasyonu/assets/35409987/f834c2f2-f6b7-40a8-9587-2f41ef0d0930" width="793" height="467"  > 
</p> 

### 2. FrmÜyeİslemleri:
   - Sisteme öğrenci kaydı yapmayı sağlar.
   - Kayıtlar, "Uye" tablosuna SQL Server üzerinde eklenir.

### 3. FrmUyeListeleme:
   - Sistemde kayıtlı kullanıcı bilgilerini görüntüler.
   - Kullanıcı bilgilerini güncelleme imkanı sağlar.

<p align="center"> 
   <img src="https://github.com/burakerdemiroglu/KutuphaneOtomasyonu/assets/35409987/58b89145-cdfa-4092-9c2e-fb0dedcb9180" width="793" height="467"  > 
</p>

### 4. FrmKitapİşlemleri:
   - Kitap bilgilerini sisteme eklemeyi sağlar.
   - Barkod numarası, sayfa sayısı, yazar, tür, raf numarası, stok miktarı gibi bilgiler girilir.
   - Kitap bilgileri "Kitap" tablosuna SQL Server üzerinde kaydedilir.

### 5. FrmKitapListeleme:
   - Sistemde kayıtlı olan kitapları listeler.
   - Kitap bilgilerini güncelleme imkanı sağlar.
     
<p align="center"> 
   <img src="https://github.com/burakerdemiroglu/KutuphaneOtomasyonu/assets/35409987/a89c5191-0fd5-4160-9335-0949d5f6459f" width="793" height="467"  > 
</p> 

### 6. FrmEmanetKitapVerme:
   - Üye ve kitap bilgilerini kontrol ederek emanet kitap verme işlemini gerçekleştirir.
   - Maksimum 3 kitap alma hakkı ve iade tarihi gibi kısıtlamalar kontrol edilir.
   - Emanet verilen kitaplar "EmanetKitaplar" ve "Sepet" tablolarıyla ilişkilendirilerek SQL Server'da kaydedilir.
     
<p align="center"> 
   <img src="https://github.com/burakerdemiroglu/KutuphaneOtomasyonu/assets/35409987/eb67c3dc-f4f1-40a1-8001-26cccbb20526" width="793" height="467"  > 
</p> 

### 7. FrmEmanetKitapGörüntüleme:
   - Emanet verilen kitapların görüntülendiği bir pencere sunar.

### 8. FrmEmanetKitapİade:
   - İade edilen kitapların sistemde güncellenmesini sağlar.
   - Kitap ve sepet tablolarındaki kayıtlar düzenlenir veya silinir.

### 9. FrmSıralama:
   - Kitap okuyan kişilerin sıralamasını gösterir.
   - En çok ve en az kitap okuyan kişilerin bilgileri sunulur.
     
<p align="center"> 
   <img src="https://github.com/burakerdemiroglu/KutuphaneOtomasyonu/assets/35409987/d8538a49-2562-4c9d-a77d-c9d9ca3b7be8" width="793" height="467" > 
</p> 

### 10. FrmGrafikler:
  - Kitap okuyan kişilerin istatistiksel grafiklerini gösterir.
    
<p align="center"> 
   <img src="https://github.com/burakerdemiroglu/KutuphaneOtomasyonu/assets/35409987/a3fe67b0-b54a-4439-bfc7-6778bef3c921"> 
</p> 

Bu şekilde, "Kütüphane Otomasyonu" projesinin farklı formlarda kullanıcı kaydı, kitap ekleme, kitap listeleme, emanet işlemleri, sıralama ve grafik gösterimi gibi işlevleri yerine getiren bir yapıya sahip olduğunu özetleyebiliriz. 
