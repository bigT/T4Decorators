T4Decorators
============

T4Decorators is a [T4](http://msdn.microsoft.com/en-AU/library/bb126445.aspx) code generator that follows a couple of simple conventions to scan for partially implemented [decorators](http://en.wikipedia.org/wiki/Decorator_pattern) (wrappers) and provide implementation for missing members. Eliminates manual overhead required to keep decorators in sync with interfaces/classes it wraps. [Here](http://tarasalenin.com/t4decorators-inception/) is a blog post with a more in-depth introduction.

__NOTE:__
Ideas and initial implementation based on generator implementation by the [T4MVC](http://t4mvc.codeplex.com/) project.

Install
-------
* Install [T4Decorators](https://www.nuget.org/packages/T4Decorators) NuGet `PM> Install-Package T4Decorators`.
* Alternatively, all you really need is the T4Decorators.tt get it from master branch to be sure.

How it works
------------
T4Decorators.tt uses the following three conventions to find partially implemented decorator classes and provide boiler plate implementation for the missing members.

1. Look for classes that end in __"Decorator"__ in the current project.
2. Look for fields that match type of the base object or one of the inherited interface(s) inside partial decorator implementation.
3. Generate default implementation for missing members by wiring them to the fields that match.

How it really works
-------------------
T4Decorator.tt generator will scan current project for classes that follow naming convention as described above. Current project is the project that contains T4Decorators.tt. Matching classes are assumed to be partially implemented decorators, if class is not already a partial class it will be converted into one. Generator will skip abstract classes even if they match the naming convention.

Generator will then scan partial decorator implementation for decoration targets. A decoration target is an internal member that matches base class or one of the inherited interfaces by type. Generator does not care how that target is initialised this is left up to the implementer. The mere fact that a class has a field that matches a base type or inherited interface implies that its been [encapsulated](http://en.wikipedia.org/wiki/Encapsulation_(object-oriented_programming)).

Lastly for each encapsulated target field generator will provide default implementation. This means the following:

* resolve public members of the target, including inherited members
* exclude members already implemented by the decorator
* generate default implementation for missing members

Default implementation is simply wiring the calls directly to the underlying target.

What doesn't work yet
---------------------
* No support for base classes. At this stage only inherited interfaces are supported.
* No support for generics.
* No support for index properties.
* No support for attributes of the decorated members.
* There will be bugs!

