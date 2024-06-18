<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CSDL.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cập nhật đơn hàng</title>
    <style type="text/css">
        body {
            margin: auto;
            padding: 20px 100px;
        }
        .auto-style1 {
            width: 25%;
        }
        .auto-style2 {
            width: 53%;
        }
        .auto-style3 {
            width: 176px;
        }
        .auto-style4 {
            width: 897px;
        }
        .auto-style5 {
            width: 176px;
            height: 29px;
        }
        .auto-style6 {
            width: 897px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                Cập nhật đơn đặt hàng</h1>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style5">Tên sản phẩm</td>
                    <td class="auto-style6">
                        <ajaxToolkit:ComboBox ID="CbTenSp" runat="server">
                        </ajaxToolkit:ComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Mã sản phẩm</td>
                    <td class="auto-style4">
                        <ajaxToolkit:ComboBox ID="CbMaSp" runat="server">
                        </ajaxToolkit:ComboBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Số lượng</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TxtSl" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Tên khách</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TxtKh" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Địa chỉ</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TxtDc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Số điện thoại</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TxtSdt" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="BtnAdd" runat="server" Text="Add" OnClick="BtnAdd_Click" Width="100px" />
                </td>
                <td>
                    <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" Width="100px"/>
                </td>
                <td>
                    <asp:Button ID="BtnRemove" runat="server" Text="Remove" OnClick="BtnRemove_Click" Width="100px" />
                </td>
            </tr>
        </table>

        <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Height="275px" Width="743px">
                 <RowStyle HorizontalAlign="Center" />
               <HeaderStyle HorizontalAlign="Center" />
            </asp:GridView>
    </form>
</body>
</html>