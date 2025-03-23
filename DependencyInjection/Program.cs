using DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Teacher sýnýfýnýn bir örneðini oluþturuyoruz
        ITeacher teacher = new Teacher("Ahmet", "Yýlmaz");

        // ClassRoom sýnýfýna Teacher örneðini enjekte ediyoruz
        ClassRoom classRoom = new ClassRoom(teacher);

        // Öðretmenin bilgilerini ekrana yazdýrýyoruz
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}