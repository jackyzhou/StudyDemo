var Person = {
    PrepareKo: function () {
        ko.bindingHandlers.date = {
            init: function (element, valueAccessor, allBindingsAccessor, viewModel) {
                element.onchange = function () {
                    var observable = valueAccessor();
                    observable(new Date(element.value));
                }
            },
            update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
                var observable = valueAccessor();
                var valueUnwrapped = ko.utils.unwrapObservable(observable);
                if ((typeof valueUnwrapped == 'string' || valueUnwrapped instanceof String) && valueUnwrapped.indexOf('/Date') === 0) {
                    var parsedDate = Person.ParseJsonDate(valueUnwrapped);
                    element.value = parsedDate.getMonth() + 1 + "/" + parsedDate.getDate() + "/" + parsedDate.getFullYear();
                    observable(parsedDate);
                }
            }
        };
    },

    ParseJsonDate: function (jsonDate) {
        return new Date(parseInt(jsonDate.substr(6)));
    },

    BindUIwithViewModel: function (viewModel) {
        ko.applyBindings(viewModel);
    },

    EvaluateJqueryUI: function () {
        //$('.dateInput').datepicker();
    },

    RegisterUIEventHandlers: function () {

        $('#Save').click(function (e) {

            e.preventDefault();  //取消事件的默认动作。

            $.ajax({
                type: "POST",
                url: Person.SaveUrl,
                data: ko.toJSON(Person.ViewModel),
                contentType: 'application/json',
                async: true,
                beforeSend: function () {
                    // Display loading image
                },
                success: function (result) {
                    // Handle the response here.
                },
                complete: function () {
                    // Hide loading image.
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    // Handle error.
                }
            });
        });
    },
};

$(document).ready(function () {
    Person.PrepareKo();
    Person.BindUIwithViewModel(Person.ViewModel);
    Person.EvaluateJqueryUI();
    Person.RegisterUIEventHandlers();
});