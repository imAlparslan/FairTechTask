# FairTechTask


## Uygulamanın Çalıştırılması

RemotingTask klasörü altında bulunan docker compose dosyası

`docker compose up`

komutu ile çalıştırılır. Compose 2 adet MSSQL Veritabanı çalıştırır 1 tanesi uygulama diğeri ise test için. 

Eğer Port'lar dolu ise yada docker kullanılmayacaksa yeni ayarlar projelerin App.Config dosyası aracılığıyla düzelenmelidir.

Ardından powershell aracılığıyla run.ps1 scripti çalıştırılır. Bu script uygulamaları derler ve çalıştırır fakat bazı durumda izin isteyebilir.

Script'in çalıştırılmasına izin vermek için

`Set-ExecutionPolicy Unrestricted -Scope Process`

Script'i çalıştırmak için

`./run.ps1`

Eğer script kullanılmayacaksa projeler derlendikten sonra çalıştırılabilir.