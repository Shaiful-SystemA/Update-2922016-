<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="sa41team7_logicuniversity_stationery.login" %>

<!DOCTYPE html>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!-- <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js" type="text/javascript"></script> -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Logic University Stationery</title>
    <%-- ------ CSS ------ --%>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <!-- <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" /> -->
    <!-- <link href="css/animate.min.css" rel="stylesheet" type="text/css" /> -->
    <!-- <link href="css/prettyPhoto.css" rel="stylesheet" type="text/css" /> -->
    <link href="css/main.css" rel="stylesheet" type="text/css" />
    <link href="css/responsive.css" rel="stylesheet" type="text/css" />
    <!--<link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"
        rel="stylesheet" type="text/css" />
    <!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <![endif]-->

    <!-- /top-link-block -->
    <!-- Jscript -->
    <script src="js/jquery.js" type="text/javascript"></script>
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <!-- <script src="js/jquery.prettyPhoto.js" type="text/javascript"></script>-->
    <!-- <script src="js/jquery.isotope.min.js" type="text/javascript"></script> -->
    <script src="js/main.js" type="text/javascript"></script>
    <script src="js/wow.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <header id="header">
                  <nav class="navbar navbar-inverse" role="banner">
                      <div class="container">
                            <div class="navbar-header">
                                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                                    <span class="sr-only">Toggle navigation</span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </button>
                                <a class="navbar-brand" href="login.aspx"><img src="images/logo.png" alt="logo" style="width:50px; height:50px"><span style="font-size:20px" />LOGIC UNIVERSITY STATIONERY</span></a>
                            </div>				
                            <div class="collapse navbar-collapse navbar-right">
                                <ul class="nav navbar-nav">
                                    
                         
                                    <li><a href="login.aspx"><img src="images\signout_icon.png" alt="icon" style="width:20px; height:20px;"/>&nbsp;Login</a></li>                        
                                </ul>
                            </div>
                        </div><!--/.container-->
                    </nav><!--/nav--> 
                </header>

                <div class="container">
                    <table>
                        <tr>
                            <td>
                                <h1>Login</h1>
                    
                                <asp:Label ID="lb_employeeid" runat="server" Text="Employee ID:"></asp:Label>&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_employeeid" runat="server"></asp:TextBox>
                                <br/><br/>
                    
                                <asp:Label ID="lb_password" runat="server" Text="Password:"></asp:Label>&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="tb_password" runat="server"></asp:TextBox>
                                <br/><br/>
                   
                                <asp:Button ID="btn_login" runat="server" Text="Login" />
                            </td>
                        </tr>
                    </table>
    </div>

            <div>
        </div>
    </form>




</body>
</html>
