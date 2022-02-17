<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="about-us.aspx.cs" Inherits="Bank_Management_System.about_us" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css">
    <link href='https://api.mapbox.com/mapbox-gl-js/v2.3.1/mapbox-gl.css' rel='stylesheet' />
    <link rel="stylesheet" href="css/main.css">
    <title>About Us</title>
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
   

     <section class="p-5 " id="about-us">
        <div class="container">
            <div class="row align-items-center justify-content-between">
                <div class="col-md">
                    <img src="img/why.svg" alt="" class="img-fluid">
                </div>
                <div class="col-md p-5" >
                    <h2>What is People's Bank Net Banking?</h2>
                    <p class="lead">
                        Welcome to the redesigned Peoples Bank Net Banking platform. With the all new One Page Banking, get to know what you own and what you owe, view and download Statements for various Accounts,  and do much more. Our intelligent interface helps you with a simpler, more intuitive and personalised banking experience. Click here to get started.                    </p>
                </div>
            </div>
    </section>
    <section class="bg-info py-5">
            <div class="container bg-dar">
            <div class="row align-items-center  justify-content-between">
                <div class="col-md p-5">
                    <h2>What is Net Banking software?</h2>
                    <p class="lead">
                       Net Banking, also known as online banking or Internet Banking, is an electronic payment system. ... Be it transferring funds to another bank account or checking the transaction statements, you can do them all and much more with the help of Internet Banking.
                    </p>
                </div>
                <div class="col-md">
                    <img src="img/collab.svg" alt="" class="img-fluid">
                </div>
            </div>
        </div>
    </section>
    
    <section class="p-5">
    </section>

    <section class="p-5 py-5"  id="contact-us">
        <div class="container">
            <div class="row g-4">
                <div class="col-md">
                    <h2 class="text-center mb-4">Contact US</h2>
                    <ul class="list-group list-group-flush lead">
                        <li class="list-group-item"><span class="fw-bold">Main Location: </span>Navi Mumbai , Belapur, 410210, Maharashtra</li>
                        <li class="list-group-item"><span class="fw-bold">Mail: </span>Peoplesbank@gmail.org
                         </li>
                        <li class="list-group-item"><span class="fw-bold">Contact Number: </span>+91 95940 83819</li>
                   
                    </ul>
                </div>
                <div class="col-md" >
                    <div class="" id="map"></div>
                </div>
            </div>
        </div>
    </section>
        
    <section class="p-5">
    </section>
   <section class="p-2 bg-dark text-white  w-100 bottom-0 text-center ">
        <div class="container ">
            <p class="lead text-start fs-3">Copyright &copy; 2022 People's Bank </p>
        </div>
    </section>

   


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

    <script src='https://api.mapbox.com/mapbox-gl-js/v2.3.1/mapbox-gl.js'></script>
    <script>
        mapboxgl.accessToken = 'pk.eyJ1Ijoic2FoaWxkb25ncmUyMCIsImEiOiJja3c4NjZoZnMwY2t1MndsZjh2bnNlMTlsIn0.mywo8bbLvejNK6VVgXzLtA';
        var map = new mapboxgl.Map({
            container: 'map',
            style: 'mapbox://styles/mapbox/streets-v11',
            center: [73.0140, 19.0691],
            zoom: 18
        });
    </script>
    </form>
</body>
</html>

