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
    <div  class="jumbotron text-center">
        <h3>Welcome to the restourant!</h3>
        <p style="margin-left: 360px">&nbsp;</p>
    </div>
        
        <p style="margin-left: 80px">
            <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="362px"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="360px"></asp:TextBox>
        </p>
        <p style="margin-left: 360px">
            <asp:Button ID="Button2" runat="server" Text="Retraive data" class="btn btn-success" OnClick="Button2_Click"/>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Label4" runat="server" Text="City:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="360px"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Label5" runat="server" Text="Postal Code:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="362px" MaxLength="12"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Label6" runat="server" Text="Phone Number:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="362px" MaxLength="15"></asp:TextBox>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Label7" runat="server" Text="Province:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Width="373px">
                <asp:ListItem>Ontario</asp:ListItem>
                <asp:ListItem>Quebec</asp:ListItem>
                <asp:ListItem>Nova Scotia</asp:ListItem>
                <asp:ListItem>New Brunswick</asp:ListItem>
                <asp:ListItem>Manitoba</asp:ListItem>
                <asp:ListItem>British Columbia</asp:ListItem>
                <asp:ListItem>Prince Edward Island	</asp:ListItem>
                <asp:ListItem>Saskatchewan</asp:ListItem>
                <asp:ListItem>Alberta</asp:ListItem>
                <asp:ListItem>Newfoundland and Labrador</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Label8" runat="server" Text="Food and Drink:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <div style="margin-left: 280px">
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Pizza</asp:ListItem>
                <asp:ListItem>Cola</asp:ListItem>
                <asp:ListItem>Beer</asp:ListItem>
                <asp:ListItem>Pasta</asp:ListItem>
                <asp:ListItem>Salad</asp:ListItem>
                <asp:ListItem>Ravioli</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <p style="margin-left: 80px">
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Delivery" GroupName="group1" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Pickup" GroupName="group1" />
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="Label9" runat="server" Text="Comments:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <textarea id="TextArea1" name="S1" maxlength="500"></textarea></p>
        <p style="margin-left: 360px">
            <asp:Button ID="Button1" runat="server" Text="Button" class="btn btn-success"/>
        </p>
    </form>
</body>
</html>
