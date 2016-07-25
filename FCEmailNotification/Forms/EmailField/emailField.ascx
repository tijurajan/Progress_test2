<%@ Control %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sf" Namespace="Telerik.Sitefinity.Web.UI" %>

<asp:Label runat="server" ID="titleLabel" CssClass="sfTxtLbl" Text="title label" AssociatedControlID="ToAddresses" />
<div class="sfFieldWrp">
    <asp:TextBox ID="ToAddresses" CssClass="sfTxt" runat="server" />
    
          
              <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
              runat="server" ErrorMessage="Please Enter Valid Email ID"
                  ValidationGroup="vgSubmit" ControlToValidate="ToAddresses"
                  CssClass="requiredFieldValidateStyle"
                  ForeColor="Red"
                  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                  </asp:RegularExpressionValidator>
    <sf:SitefinityLabel runat="server" ID="descriptionLabel" WrapperTagName="div" CssClass="sfDescription"/>
    <sf:SitefinityLabel runat="server" ID="exampleLabel" WrapperTagName="div" CssClass="sfExample"/>
</div>