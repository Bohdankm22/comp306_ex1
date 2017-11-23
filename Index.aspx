<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="GoogleCloudSamples.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizzashop</title>
    <link href="content/css/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        #TextArea1 {
            height: 86px;
            width: 394px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron text-center">
            <h3>Welcome to the restaurant!</h3>
            <p style="margin-left: 360px">&nbsp;</p>
        </div>
        <div class="table" style="margin-left: 80px">
            <div class="row">
                
                <div class="col-2">

                    <asp:Label ID="Label2" runat="server" Text="First Name:" CssClass="column"></asp:Label>
                    <br />
                </div>
                <div class="col-3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="350px"></asp:TextBox>
                    <br />
                </div>
                <div class="col-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is required" ForeColor="Red" ValidationGroup="userData"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>
          <div class="row"><div class="col-2"> </div></div>
            <div class="row">
                <div class="col-2">

                    <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
                </div>
                <div class="col-3">
                    <asp:TextBox ID="TextBox2" runat="server" Width="350px"></asp:TextBox>
                </div>
                <div class="col-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Surname is required" ForeColor="Red" ValidationGroup="userData"></asp:RequiredFieldValidator>
                </div>

            </div>
          
            <div class="row">
                <div class="col-2"></div>
                <div class="col-3">

                    <asp:Button ID="Button2" runat="server" Text="Remember Me" class="btn btn-success" OnClick="Button2_Click" />
                </div>
            </div>
       
            <div class="row">
                <div class="col-2">
                    <asp:Label ID="Label4" runat="server" Text="City:"></asp:Label>
                </div>
                <div class="col-3">
                    <asp:TextBox ID="TextBox3" runat="server" Width="350px"></asp:TextBox>
                </div>
                <div class="col-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="City is required" ForeColor="Red" ValidationGroup="userData"></asp:RequiredFieldValidator>
                </div>

            </div>
           
            <div class="row">
                <div class="col-2">
                    <asp:Label ID="Label5" runat="server" Text="Postal Code:"></asp:Label>
                </div>
                <div class="col-3">
                    <asp:TextBox ID="TextBox4" runat="server" Width="350px" MaxLength="12"></asp:TextBox>
                </div>
                <div class="col-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Postal Code is required" ForeColor="Red" ValidationGroup="userData"></asp:RequiredFieldValidator>
                </div>

            </div>
       
            <div class="row">
                <div class="col-2">
                    <asp:Label ID="Label6" runat="server" Text="Phone Number:"></asp:Label>
                </div>
                <div class="col-3">
                    <asp:TextBox ID="TextBox5" runat="server" Width="350px" MaxLength="15"></asp:TextBox>
                </div>
                <div class="col-4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Phone number is required" ForeColor="Red" ValidationGroup="userData"></asp:RequiredFieldValidator>
                </div>

            </div>
          
            <div class="row">
                <div class="col-2">
                    <asp:Label ID="Label7" runat="server" Text="Province:"></asp:Label>
                </div>
                <div class="col-3">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="350px">
                        <asp:ListItem>Ontario</asp:ListItem>
                        <asp:ListItem>Quebec</asp:ListItem>
                        <asp:ListItem>Nova Scotia</asp:ListItem>
                        <asp:ListItem>New Brunswick</asp:ListItem>
                        <asp:ListItem>Manitoba</asp:ListItem>
                        <asp:ListItem>British Columbia</asp:ListItem>
                        <asp:ListItem>Prince Edward Island</asp:ListItem>
                        <asp:ListItem>Saskatchewan</asp:ListItem>
                        <asp:ListItem>Alberta</asp:ListItem>
                        <asp:ListItem>Newfoundland and Labrador</asp:ListItem>
                    </asp:DropDownList>
                </div>

            </div>
         
            <div class="row">
                <div class="col-2">
                    <asp:Label ID="Label8" runat="server" Text="Food and Drink:"></asp:Label>
                </div>
                <div class="col-3">


                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="171px">
                        <asp:ListItem>Pizza</asp:ListItem>
                        <asp:ListItem>Cola</asp:ListItem>
                        <asp:ListItem>Beer</asp:ListItem>
                        <asp:ListItem>Pasta</asp:ListItem>
                        <asp:ListItem>Salad</asp:ListItem>
                        <asp:ListItem>Ravioli</asp:ListItem>
                    </asp:CheckBoxList>
                </div>

            </div>
        
            <div class="row">
                <div class="col-2">
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Delivery" GroupName="group1" Checked="True" />
                </div>
                <div class="col-3">
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Pickup" GroupName="group1" />
                </div>
            </div>
         
            <div class="row">
                <div class="col-2">
                    <asp:Label ID="Label9" runat="server" Text="Comments:"></asp:Label>
                </div>
                <div class="col-3">
                    <asp:TextBox ID="TextBox6" runat="server" Height="134px" MaxLength="400" TextMode="MultiLine" Width="350px"></asp:TextBox>
                </div>
            </div>

        </div>
        <p style="margin-left: 360px">
            <asp:Button ID="Button1" runat="server" Text="Order" class="btn btn-success" OnClick="Button1_Click" ValidationGroup="userData" />
        </p>
    </form>
</body>
</html>
