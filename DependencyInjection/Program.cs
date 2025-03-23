using DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Teacher s�n�f�n�n bir �rne�ini olu�turuyoruz
        ITeacher teacher = new Teacher("Ahmet", "Y�lmaz");

        // ClassRoom s�n�f�na Teacher �rne�ini enjekte ediyoruz
        ClassRoom classRoom = new ClassRoom(teacher);

        // ��retmenin bilgilerini ekrana yazd�r�yoruz
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}