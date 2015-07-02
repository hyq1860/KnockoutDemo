//
// Observable CSS Class Binding
//
ko.bindingHandlers['class'] = {
    update: function (element, valueAccessor) {
        var currentValue = ko.utils.unwrapObservable(valueAccessor()),
            prevValue = element['__ko__previousClassValue__'],

            // Handles updating adding/removing classes
            addOrRemoveClasses = function (singleValueOrArray, shouldHaveClass) {
                if (Object.prototype.toString.call(singleValueOrArray) === '[object Array]') {          
                    ko.utils.arrayForEach(singleValueOrArray, function (cssClass) {
                      var value = ko.utils.unwrapObservable(cssClass);
                      ko.utils.toggleDomNodeCssClass(element, value, shouldHaveClass);
                    });
                } else if (singleValueOrArray) {
                    ko.utils.toggleDomNodeCssClass(element, singleValueOrArray, shouldHaveClass);
                }
            };

        // Remove old value(s) (preserves any existing CSS classes)
        addOrRemoveClasses(prevValue, false);

        // Set new value(s)
        addOrRemoveClasses(currentValue, true);

        // Store a copy of the current value
        element['__ko__previousClassValue__'] = currentValue.concat();
    }
};

//ko.bindingHandlers.sortable = {
//    init: function (element, valueAccessor, allBindingsAccessor, viewModel) {
//        var config = valueAccessor();
//        if (!config) { return; }

//        var allBindings = allBindingsAccessor();
//        var array = allBindings.foreach || allBindings.template.foreach;

//        var $list = jQuery(element);

//        $list
//          .data('ko-sort-array', array)
//          .sortable(config)
//          .bind('sortstart', function (event, ui) {
//              ui.item.data('ko-sort-array', array);
//              ui.item.data('ko-sort-index', ui.item.index());
//          })
//          .bind('sortupdate', function (event, ui) {
//              var $newList = ui.item.parent();
//              if ($newList[0] != $list[0]) { return; }

//              var oldArray = ui.item.data('ko-sort-array');
//              var oldIndex = ui.item.data('ko-sort-index');

//              var newArray = $newList.data('ko-sort-array');
//              var newIndex = ui.item.index();

//              var item = oldArray.splice(oldIndex, 0)[0];
//              newArray.splice(newIndex, 0, item);
//          });
//    }
//};