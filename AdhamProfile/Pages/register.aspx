<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="AdhamProfile.Pages.register" %>

<!DOCTYPE html>

<html lang="en">
    <head runat="server">
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>My Application</title>
        <link href="~/Content/css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js"></script>
        <style type="text/css">
            .auto-style1 {
                position: relative;
                width: 100%;
                flex: 0 0 50%;
                max-width: 50%;
                left: 0px;
                top: 0px;
                padding-left: 0.75rem;
                padding-right: 0.75rem;
            }
        </style>
    </head>
    <body class="bg-secondary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-7">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Create Account</h3></div>
                                    <div class="card-body">
                                        <form runat="server">
                                            <div class="form-group">
                                                <label class="small mb-1" for="inputFirstName">Full Name</label>
                                                <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control py-4" placeholder="Enter full name" required />
                                            </div>
                                            <div class="form-group">
                                                <label class="small mb-1" for="inputEmailAddress">Email</label>
                                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control py-4" TextMode="email" aria-describedby="emailHelp" placeholder="Enter email address" required />
                                            </div>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputPassword">Password</label>
                                                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control py-4" placeholder="Enter Password" required />
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputConfirmPassword">Confirm Password</label>
                                                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="form-control py-4" placeholder="Confirm Password" required />
                                                    </div>
                                                </div>
                                            </div>
                                            <!--div class="form-group mt-4 mb-0"><a class="btn btn-primary btn-block" href="login.aspx">Create Account</a></div-->
                                            <asp:Button id="btnCreateLogin"  runat="server" Text="Create Account" OnClick="BtnCreatelogin_Click" CssClass="btn btn-primary btn-block"></asp:Button>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center">
                                        <div class="small"><a href="login.aspx">Have an account? Go to login</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
            <div id="layoutAuthentication_footer">
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid">
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy; Your Website 2020</div>
                            <div>
                                <a href="#">Privacy Policy</a>
                                &middot;
                                <a href="#">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <script src="https://code.jquery.com/jquery-3.5.1.min.js" crossorigin="anonymous"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js"></script>
        <script src="../Content/js/scripts.js"></script>
    </body>
</html>

