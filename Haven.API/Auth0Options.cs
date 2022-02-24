
public class Auth0Options {
    public const string Key="Auth0";
    public string Audience { get; set; } = string.Empty;
    public string Domain { get; set; }  = string.Empty;

    public string Authority { 
        get {
            return $"https://{Domain}/";
        }
    }
}