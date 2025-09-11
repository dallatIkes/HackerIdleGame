using System;

public class Player
{
    private string Username { get; set; }
    public Currency Crypto { get; private set; }

    public Player(string username)
    {
        Username = username;
        Crypto = new Currency("crypto");
    }
}
