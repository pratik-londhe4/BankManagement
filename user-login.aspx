<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user-login.aspx.cs" Inherits="Bank_Management_System.user_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css">
    <link href='https://api.mapbox.com/mapbox-gl-js/v2.3.1/mapbox-gl.css' rel='stylesheet' />
    <link rel="stylesheet" href="css/main.css">
    <title>User Signin</title>
</head>
<body>
    <form id="form1" runat="server">
    <section>
        <nav class="navbar navbar-expand-md bg-dark navbar-dark  fixed-top btn " >
            <div class="container">
                <a href="#" class="navbar-brand  fs-2">People's Bank</a>
 
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navmenu">
                    <span class="navbar-toggler-icon"></span>
                </button>
 
                <div class="collapse navbar-collapse " id="navmenu">
                    <ul class="navbar-nav ms-auto">
                        <li class="nav-item">
                            <a href="index.aspx" class="nav-link">Home</a>
                        </li>
                        <li class="nav-item">
                            <a href="login-type.aspx" class="nav-link">Signin</a>
                        </li>
                        <li class="nav-item">
                            <a href="about-us.aspx" class="nav-link">About Us</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </section>

    <section class="p-5 text-dark main">
        <div class="container">
            <div class="row">
                <div class="col-md col-md-6 ">
                    <img src="img/u-a-login.svg" alt="" class="img-fluid my-md-5">
                </div>
           
            <div class="col-md ">
                <div class="card shadow p-3 mb-5 bg-body rounded">
                    <main>
        <div class="login-box p-3 ">
            <h2>Login</h2>
            <asp:TextBox ID="username" CssClass="input-group"  placeholder="Enter Username" runat="server"></asp:TextBox><br>
            <asp:TextBox ID="txtpass" CssClass="input-group"  placeholder="Enter Password" runat="server" TextMode="Password"></asp:TextBox>
           <br /> <asp:Label ID="errormsg" runat="server" ForeColor="Red"></asp:Label><br/>
            <asp:Button ID="blogin" CssClass="btn btn-info input-group" runat="server" Text="Login" onclick="blogin_Click"   /><br><br>
            <asp:label ID="successmsg" runat="server"></asp:label>

        </div>
    </main>
                </div>
            </div>
        </div>
      </div>
    </section>

   <section class="p-2 bg-dark text-white  w-100 bottom-0 text-center ">
        <div class="container ">
            <p class="lead text-start fs-3">Copyright &copy; 2022 People's Bank </p>
        </div>
    </section>
    

    

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    
    
    </form>
</body>
</html>