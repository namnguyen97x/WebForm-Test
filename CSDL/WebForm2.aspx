<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CSDL.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            padding: 30px 100px;
        }
        .auto-style1 {
            width: 580px;
        }
        .auto-style2 {
            width: 168px;
        }
        .auto-style3 {
            width: 645px;
        }
        .auto-style4 {
            width: 574px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cập nhật sản phẩm</h1>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Tên sản phẩm</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Mã sản phẩm</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Giá</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="auto-style4">
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Add" Width="100px" OnClick="Button1_Click"/>
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Update" Width="100px" OnClick="Button2_Click" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Remove" Width="100px" OnClick="Button3_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="210px" Width="839px">
        </asp:GridView>
    </form>
</body>
</html>
