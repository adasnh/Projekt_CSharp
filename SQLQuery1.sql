create table pracownicy(
id_pracownika int primary key IDENTITY (1,1),
imie varchar (30),
nazwisko varchar (30),
);

create table artykuly(
id_artykulu int primary key IDENTITY (1,1),
nazwa varchar (40),
koszt_zakup money,
ilosc_sztuk int,
);

create table wydania(
id_zamowienia int primary key IDENTITY (1,1),
id_artykulu int foreign key references artykuly(id_artykulu),
id_pracownika int foreign key references pracownicy(id_Pracownika),
ilosc_sztuk int,
data_wydania datetime,

);

create table uzytkownicy(
id int primary key IDENTITY (1,1),
nazwa varchar (20),
haslo varchar (20),
status bit,
rola varchar(20),
);

insert into dbo.artykuly VALUES
('Taśma malarska 25mm x 5m', 8, 57),
('Taśma malarska 50mm x 5m', 12, 44),
('Śruba M6', 1, 609),
('Nakrętka M6', 1, 655)

insert into dbo.pracownicy VALUES
('Jan', 'Kowalski'),
('Krzysztof', 'Nowak'),
('Janusz', 'Wujcik')

insert into dbo.uzytkownicy VALUES
('admin', 'admin', 1, 'admin'),
('user', 'user', 1, 'user')

insert into dbo.wydania VALUES
(2, 1, 10, '2020-01-04'),
(1, 2, 2, '2020-01-04'),
(3, 2, 15, '2020-11-14')
