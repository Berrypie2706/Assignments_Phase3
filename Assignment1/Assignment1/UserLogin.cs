
    public class UserLogin
    {
    public string UserId { get; set; }
    public string Password { get; set; }
    public string validateId()
    {
        string msg = "";
        string userId = "12421";
        UserId = Console.ReadLine();

          if (UserId == null)
        {
            throw new InvalidOperationException();
        }
          else if(UserId==userId)
        {
            msg = "Enter Password";
        }
        else
        {
           msg = "Invalid Id";
          
           
        }
        return msg;


    }
    public string validatepwd()
    {
        string msg = "";
        string pwd = "Aniket@123";
        Password = Console.ReadLine();

        if (Password == null)
        {
            throw new InvalidOperationException();
        }
        else if (pwd==Password)
        {
           msg = "Login Successful";
        }
        else
        {
            msg="Invalid Password";
             
        }
        return msg;
    }
}
