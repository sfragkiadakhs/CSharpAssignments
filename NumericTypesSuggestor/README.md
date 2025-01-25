# Numeric Type Suggestor 
This appication's purpose is to suggest the numeric type of data the user needs.
The user has to set the min and max values to set the range of the numeric type, In addition, there are 2 checkboxes.
1. The <Integral only?> which sets if the numeric type has floating point or not.
2. The Must be precise? which is visible only if the <Integral only?> is not checked. This means that the numeric type is a floating point and depending the scope of the numeric type, can either precised(decimal) or with numeric type with not that accuracy (like doubles and floats).

 The Suggested Type Label, suggests the type that in the end is more suited for the users needs. There are safechecks for the user to add valid numbers and the condition that minValue < maxValue is met always.

The initial state of the App can be viewed in the following image: 
![text](imgs/ApplicationAppearance.png)

