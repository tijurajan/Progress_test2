Type.registerNamespace("SitefinityWebApp.Forms.EmailField");

SitefinityWebApp.Forms.EmailField.emailField = function (element) {
    this._textbox = null;
    this._dataFieldName = null;
    SitefinityWebApp.Forms.EmailField.emailField.initializeBase(this, [element]);
}

SitefinityWebApp.Forms.EmailField.emailField.prototype = {
    /* --------------------------------- set up and tear down ---------------------------- */

    /* --------------------------------- public methods ---------------------------------- */

    // Gets the value of the field control.
    get_value: function () {
        return jQuery(this._textbox).val();
    },

    // Sets the value of the text field control depending on DisplayMode.
    set_value: function (value) {
        jQuery(this._textbox).val(value);
    },

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties -------------------------------------- */

    get_textbox: function () {
        return this._textbox;
    },

    set_textbox: function (value) {
        this._textbox = value;
    },

    get_dataFieldName: function () {
        return this._dataFieldName;
    },

    set_dataFieldName: function (value) {
        this._dataFieldName = value;
    }
}

SitefinityWebApp.Forms.EmailField.emailField.registerClass('SitefinityWebApp.Forms.EmailField.emailField', Telerik.Sitefinity.Web.UI.Fields.FieldControl);