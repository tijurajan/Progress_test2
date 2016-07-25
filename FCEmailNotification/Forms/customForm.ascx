<%@ Control %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sf" Namespace="Telerik.Sitefinity.Web.UI" %>

<asp:Label runat="server" ID="titleLabel" CssClass="sfTxtLbl" Text="Email: " AssociatedControlID="ToAddresses" />
<div class="sfFieldWrp">
    <asp:TextBox ID="ToAddresses" CssClass="sfTxt" runat="server" />
    <sf:SitefinityLabel runat="server" ID="descriptionLabel" WrapperTagName="div" CssClass="sfDescription"/>
    <sf:SitefinityLabel runat="server" ID="exampleLabel" WrapperTagName="div" CssClass="sfExample"/>
</div>