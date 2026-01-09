int nilai;
string nama;

Console.WriteLine("AAplikasi Nilai Siswa");

Console.Write("Nama Siswa: ");
nama  = Console.ReadLine();

Console.Write("Nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
{
    Console.WriteLine("Selamat, Lulus!");
}
else
{
    Console.WriteLine("Maaf, Belum Lulus!");
}
