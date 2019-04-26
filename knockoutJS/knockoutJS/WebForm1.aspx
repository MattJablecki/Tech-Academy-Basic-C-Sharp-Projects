<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="knockoutJS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Knockout Demo</title>
    <link href="Content/bootstrap-grid.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/jquery.tmpl.js"></script>
    <script src="Scripts/knockout-3.5.0.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container bg-primary mb-5">
            <div class="page-header text-center">
                <h1>Tech Academy Inventory Management</h1>
            </div>
        </div>
            <div class="ml-4 mb-4">
                <p>Product Name: <input type="text" data-bind="value: productName" /></p>
                <p>Price: <input type="text" data-bind="value: price" /></p>
                <p>Quantity: <input type="text" data-bind="value: quantity" /></p>
                <p>Manufacturer: <input type="text" data-bind="value: manufacturer" /></p>
                <button class="btn-primary" data-bind="click: addProduct">Add Product</button>
            </div>

            <ul data-bind="template: { name: 'productsTemplate', foreach: products }"></ul>
            <script type="text/html" id="productsTemplate">
                <li><h6>Product: ${$data.pname}</h6> <h6>Price: $${$data.price}</h6> <h6>Quantity: ${$data.quantity}</h6><h6>Manufacturer: ${$data.manufacturer}</h6> <h6>Added: ${new Date}</h6>
                    <button class="btn-primary" data-bind="click: remove">Remove</button>
                </li>
            </script>
    </div>
    </form>
    
    <script type="text/javascript">
        function Product(pname, price, quantity, manufacturer) {
            return {
                pname: ko.observable(pname),
                price: ko.observable(price),
                quantity: ko.observable(quantity),
                manufacturer: ko.observable(manufacturer),
                remove: function () {
                    vm.products.remove(this);
                }
            };
        }

        var vm = {
            productName: ko.observable("New Product"),
            price: ko.observable(0),
            quantity: ko.observable(0),
            manufacturer: ko.observable("Manufacturer"),
            products: ko.observableArray([]),
            addProduct: function () {
                vm.products.push(new Product(this.productName(), this.price(), this.quantity(), this.manufacturer()));
            }
        };

        ko.applyBindings(vm);
    </script>
</body>
</html>
