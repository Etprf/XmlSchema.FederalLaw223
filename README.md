# XmlSchema.FederalLaw223

![NuGet](https://github.com/Etprf/XmlSchema.FederalLaw223/workflows/NuGet/badge.svg)

The library contains XML schema classes for zakupki.gov.ru 223 federal law entities. Distributed as a NuGet package.

## Development

### Generating classes

The schema XSD-files should be located at `./xsd` directory.

For generating classes based on that schema files, run the "Developer Command Prompt for VS 20**" console tool on your Windows machine.
Then run the following command from the `./xsd` directory:

```console
xsd /c /o:. Types.xsd reference.xsd purchasePlan.xsd contract.xsd purchase.xsd /n:XmlSchema.FederalLaw223
rename Types_reference_purchasePlan_contract_purchase.cs XmlSchema.cs
move /y XmlSchema.cs ../src/XmlSchema.cs
```
