﻿
# Tags

***Domain Module***  

This view contains details information about Tags domain module, including:
- other related modules
- related processes
- related building blocks
- related deployable units
- engaged people: actors, development teams, business stakeholders  

---



## Domain Perspective


### Related modules

```mermaid
  flowchart TB
    0([Contacts])
    class 0 DomainPerspective
    1(Tags)
    class 1 DomainPerspective
    0---1
    1-->|is part of|0
    1---0
    2([Old Api])
    class 2 DomainPerspective
    1-->|contains|2
    3([Rest Api])
    class 3 DomainPerspective
    1-->|contains|3
    linkStyle 0,2 stroke:none
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

### Related processes

No related processes were found.  

### Direct building blocks

No direct building blocks were found.  

## Technology Perspective


### Related deployable units

No related deployable units were found.  

## People Perspective


### Engaged people

No engaged people were found.  

## Next steps


### Zoom-in


#### Domain perspective


##### Domain Modules

[Old Api](OldApi/OldApi.md)  
[Rest Api](RestApi/RestApi.md)  

### Zoom-out


#### Domain perspective


##### Domain Modules

[Contacts](../Contacts.md)  

---

[P3 Model](https://github.com/P3-model/P3-model) documentation generated from source code using [.net tooling](https://github.com/P3-model/P3-model-dotnet)