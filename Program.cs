using System;
using System.Collections;

class Program{

    static void Main(string[] args){

        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Ayşe";
        ogrenci.Soyisim1 = "yılmaz";
        ogrenci.No1 = 29;
        ogrenci.Sınıf1 = 3;
        ogrenci.OgrenciBilgileriGetir();

        ogrenci.SınıfArttır();
        ogrenci.OgrenciBilgileriGetir();

        Ogrenci ogrenci1 = new Ogrenci("deniz","çöl",216,7);
        ogrenci1.SınıfAzalt();
        
    }
}

class Ogrenci{

    private string isim;
    private string Soyisim;
    private int No;
    private int Sınıf;

    

    public Ogrenci(){

    }

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim1 { get => Soyisim; set => Soyisim = value; }
    public int No1 { get => No; set => No = value; }
    public int Sınıf1 
    {
        get => Sınıf;
        set
        {
             if (value < 1)
             {
                Console.WriteLine("Sınıf En Az Bir Olmalı");
             }else{
                Sınıf = value;
             }
        } 
    }

    public Ogrenci(string isim,string Soyisim,int No,int Sınıf){
        isim = this.isim;
        Soyisim = this.Soyisim;
        No = this.No;
        Sınıf = this.Sınıf;

    }

    public void OgrenciBilgileriGetir(){
        Console.WriteLine("ögrenci adı : " + isim);
        Console.WriteLine("ögrenci soyadı : " + Soyisim);
        Console.WriteLine("ögrenci no : " + No);
        Console.WriteLine("ögrenci sınıf : " + Sınıf);

    }

    public void SınıfArttır(){
        Sınıf = this.Sınıf +1;
    }
    public void SınıfAzalt(){
        Sınıf = this.Sınıf -1;
    }
}
 