<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Test.WebForm4" %>

<%@ Register Assembly="MyRepeater" Namespace="MyRepeater" TagPrefix="cc2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <cc2:MyRepeater4 ID="ServerControl1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                    <HeaderTemplate>
                        <li>我是header</li>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><%#Eval("name") %>
                        </li>
                    </ItemTemplate>
                    <FooterTemplate>
                        <li>我是Footer</li>
                    </FooterTemplate>
                    <EmptyDataTemplate>
                        <li style="color: red;">没有数据！</li>
                    </EmptyDataTemplate>
                </cc2:MyRepeater4>
            </ul>
        </div>
    </form>
</body>
</html>
