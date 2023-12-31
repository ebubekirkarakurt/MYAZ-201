namespace MusicApp.Models;

public class Users{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Musics> LikedMusic { get; set; }

    public Users(){}

    public Users(int id, string name, string email, string password)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
    }
}