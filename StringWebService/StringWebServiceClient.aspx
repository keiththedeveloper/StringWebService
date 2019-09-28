<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StringWebServiceClient.aspx.cs" Inherits="StringWebService.StringWebServiceClient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome to Web Service Example:<br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter a String:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="VowelCheck" runat="server" 
            Text="Check Vowels Count" onclick="VowelCheck_Click" />
        <br />
        <br />
        There are
        <asp:Label ID="Label5" runat="server"></asp:Label>
&nbsp;vowels in this String.<br />
        <br />
        Enter the Start Position:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter the Length of the Substring:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SubstringGen" runat="server" 
            Text="Generate Substring" onclick="SubstringGen_Click"  />
        <br />
        <br />
        The&nbsp; Generated Substring is:&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter a Subtring"></asp:Label>
        :
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Strcheck" runat="server" 
            Text="Check if this is a Substring a given String" 
            onclick="Strcheck_Click" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="chklabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
