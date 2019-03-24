# SmartData
SmartData is Excel for Enterprise Data (Such as all kinds of Databases, Data Services, or other structured data). Here is source code of its demos along with some documents. You may find more on http://smartdatahk.blogspot.hk/. 

## Basic Architecture

### Main App
Dynamic LINQ style data/class access(multi tables could be involved driven by end users)
Dynamic Matching between Data and UI Templates
Dynamic Switching UI Templates
Dynamic Defining/Improving UI Templates

### Base Module

**Data Layer:** 
1. Dynamic LINQ Extended Class/Table supported
2. Dynamic LINQ operations (Sort/Filter/ Groupby/Summary)

**UI Template (Class/Table Level)**
**UI Template (Property/Field Level)** 

## Data/Object Layer
**ORM (for Databases):**
1. UI Binding, especially LINQ support
2. General to all kinds of databases
3. Mass Data support (Server Mode) 
4. Performance
5. Dynamic classes building
Solution: Customized ORM framework, based on a mature one

**OData ( for Data services):**
1.UI Binding
2.Dynamic classes building
Solution: Dynamic classes generation

**General Object**
1.UI Binding, especially LINQ support
2.General to all kinds of Objects
3.Built-in Property Editor support

### UI Template (Class/Table Level)
**Master-Detail Grid**
1.Dynamic Detail Generation
2.Performance

**Pivot Grid**
1. Built-in multi tables (classes) support

**Layout (Form)** 
1. Built-in multi tables (classes) support


### UI Template (Property/Field Level)
All kinds of inplace editors
1. LinqStyle Data Binding (Multi Classes/Tables involved)
2. Excel like Data Binding defining
3. Templates Management (Save/Restore and dynamic matching)

## Highly Used C# Features 

LINQ/ORM
Serialization/Reflection/Low level Assembly access

