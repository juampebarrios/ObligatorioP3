#pragma checksum "C:\Users\renzo\Desktop\Obligatorio P3 2022\ObligatorioP3\ObligatorioP32022\Obligatorio\Views\Planta\AgregarPlanta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b51b3c016692203d9f67434e569d7e82681a44e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_AgregarPlanta), @"mvc.1.0.view", @"/Views/Planta/AgregarPlanta.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\renzo\Desktop\Obligatorio P3 2022\ObligatorioP3\ObligatorioP32022\Obligatorio\Views\_ViewImports.cshtml"
using Obligatorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\renzo\Desktop\Obligatorio P3 2022\ObligatorioP3\ObligatorioP32022\Obligatorio\Views\_ViewImports.cshtml"
using Obligatorio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b51b3c016692203d9f67434e569d7e82681a44e", @"/Views/Planta/AgregarPlanta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718c816bb28de69d7646d9da673eaff207aa081", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_AgregarPlanta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card p-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PlantaAgregada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\renzo\Desktop\Obligatorio P3 2022\ObligatorioP3\ObligatorioP32022\Obligatorio\Views\Planta\AgregarPlanta.cshtml"
   ViewData["Title"] = "Agregar Planta"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col col-sm-8\">\r\n        <h1>");
#nullable restore
#line 6 "C:\Users\renzo\Desktop\Obligatorio P3 2022\ObligatorioP3\ObligatorioP32022\Obligatorio\Views\Planta\AgregarPlanta.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>Complete todos los campos con la infromación de la planta a agregar.</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b51b3c016692203d9f67434e569d7e82681a44e5447", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"selPlantType\">Tipo</label>\r\n                <select class=\"form-control\" id=\"selPlantType\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b51b3c016692203d9f67434e569d7e82681a44e5898", async() => {
                    WriteLiteral("Seleccione...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b51b3c016692203d9f67434e569d7e82681a44e7148", async() => {
                    WriteLiteral("test");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group"">
                <label for=""txtPlantNameC"">Nombre científico:</label>
                <input type=""text"" class=""form-control"" id=""txtPlantNameC"" placeholder=""Nombre científico"">
            </div>
            <div class=""form-group"">
                <label for=""txtPlantNameV"">Nombres vulgares:</label>
                <div class=""input-group"">
                    <input type=""text"" class=""form-control"" id=""txtPlantNameV"" placeholder=""Nombres vulgares"">
                    <button class=""btn btn-outline-primary"" type=""button"" id=""btnAddName"">Agregar nombre</button>
                </div>
                <ul class=""list-group col col-sm-6 mt-4"" id=""listNames""></ul>
            </div>
            <div class=""form-group"">
                <label for=""txtPlantAmb"">Ambiente:</label>
                <input type=""text"" class=""form-control"" id=""txtPlantAmb"" placeholder=""Ambiente"">
            </div>
            <div cla");
                WriteLiteral(@"ss=""form-group"">
                <label for=""txtPlantHeight"">Altura máxima (en metros):</label>
                <input type=""number"" class=""form-control"" id=""txtPlantHeight"" placeholder=""Altura máxima"" min=""0"">
            </div>
            <div class=""form-group"">
                <label for=""txtPlantPrice"">Precio unitario (en pesos):</label>
                <input type=""number"" class=""form-control"" id=""txtPlantPrice"" placeholder=""Precio unitario"" min=""0"">
            </div>
            <div class=""form-group"">
                <label for=""txtPlantImg"">Imagen:</label>
                <input type=""file"" class=""form-control"" id=""txtPlantImg"" multiple>
            </div>
            <div class=""form-group"">
                <label for=""txtPlantDesc"">Decripción:</label>
                <textarea class=""form-control"" id=""txtPlantDesc"" placeholder=""Añada una descripción..."" onkeydown=""countCharacters()"" style=""resize: none; height: 250px;""></textarea>
                <span class=""pull-right label labe");
                WriteLiteral("l-default\" id=\"characterCounter\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <INPUT type=\"button\" id=\"btnSavePlant\" class=\"btn btn-primary float-right mt-2\" value=\"Agregar planta\">>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>


<script>
    let textRemaining = 0;
    function countCharacters() {
        let text_min = 10;
        let text_max = 500;
        $('#characterCounter').html('0 / ' + text_max);

        $('#txtPlantDesc').keyup(function () {
            let text_length = $('#txtPlantDesc').val().length;
            text_remaining = text_max - text_length;

            $('#characterCounter').html(text_length + ' / ' + text_max);
            if (text_length > text_max || text_length < text_min) $('#characterCounter').css(""color"", ""red"");
            else $('#characterCounter').css(""color"", ""black"");
        });
    }

    let arrayNamesV = [];
    $('#btnAddName').click(function () {
        $('#listNames').empty();
        if (!arrayNamesV.includes($('#txtPlantNameV').val().trim()) && $('#txtPlantNameV').val().trim() !== '') arrayNamesV.push($('#txtPlantNameV').val().trim());
        else alert(""El nombre no debe ser vacío o repetido."");
        $('#txtPlantNameV').val('');
 ");
            WriteLiteral(@"       fullList()
    });

    function fullList() {
        arrayNamesV.map(function (i) {
            $('#listNames').append(`<li class='list-group-item d-block' id='li_${i}'>
                                        <span class='mt-1 float-left'>${i}</span>
                                        <button type=""button"" id='btnDeleteItem_${i}'class=""btn btn-outline-danger btn-sm float-right"">Eliminar</button>
                                    </li>`
            );
        });
    }

    $('body').on('click', ""button[id^='btnDeleteItem_']"", function () {
        let id = this.id.substr(14);
        let pos = arrayNamesV.indexOf(id);
        arrayNamesV.splice(pos, 1);
        $(listNames).empty();
        fullList();
    });

    $('#btnSavePlant').click(function () {
        if (validateParams()) {
            callController();
        }
    });

    function validateParams() {
        let paramType = validateType();
        let nameC = validateNameC();
        let nameV = vali");
            WriteLiteral("dateNameV();\r\n        let amb = validateAmb();\r\n        let height = validateHeight();\r\n        let price = validatePrice();\r\n");
            WriteLiteral(@"        let desc = validateDesc();

        let valid = false;

        if (paramType && nameC && nameV & amb && height && price && desc) {
            valid = true;
        }

        return valid;
    }

    function validateType() {
        let valid = false;
        if ($('#selPlantType').val() !== '') valid = true;
        return valid;
    }

    function validateNameC() {
        let valid = false;
        if ($('#txtPlantNameC').val() !== '') valid = true;
        return valid;
    }

    function validateNameV() {
        let valid = false;
        if (arrayNamesV.length > 0) valid = true;
        return valid;
    }

    function validateAmb() {
        let valid = false;
        if ($('#txtPlantAmb').val() !== '') valid = true;
        return valid;
    }

    function validateHeight() {
        let valid = false;
        if ($('#txtPlantHeight').val() !== '' && !isNaN($('#txtPlantHeight').val())) valid = true;
        return valid;
    }

    function valid");
            WriteLiteral(@"atePrice() {
        let valid = false;
        if ($('#txtPlantPrice').val() !== '' && !isNaN($('#txtPlantPrice').val())) valid = true;
        return valid;
    }

    function validateDesc() {
        let valid = false;
        if ($('#txtPlantDesc').val() !== '' && $('#txtPlantDesc').val().length < 500 && $('#txtPlantDesc').val().length > 10) valid = true;
        return valid;
    }

    async function callController() {
        console.log('callController');
        let tipo = $('#selPlantType').val();
        let nombreC = $('#txtPlantNameC').val();
        let nombresV = arrayNamesV.join();
        let amb = $('#txtPlantAmb').val();
        let altura = $('#txtPlantHeight').val();
        let precio = $('#txtPlantPrice').val();
        let desc = $('#txtPlantDesc').val();
        let img = $('#txtPlantImg')[0].files;

        let formData = new FormData();
        formData.append(""cientifico"", nombreC);
        formData.append(""vulgares"", nombresV);
        formData.append(""t");
            WriteLiteral(@"ipoPlanta"", tipo);
        formData.append(""ambient"", amb);
        formData.append(""altura"", altura);
        formData.append(""precio"", precio);
        formData.append(""descripcion"", desc);
        formData.append(""imagen"", img[0]);

        await $.ajax({
            type: ""POST"",
            url: '/Planta/PlantaAgregada',
            data: formData,
            contentType: false,
            processData: false,
            success: function (res) {
                console.log(res);
            },
            error: function (req, status, error) {
                console.log(error);
            }
        });
    }
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
