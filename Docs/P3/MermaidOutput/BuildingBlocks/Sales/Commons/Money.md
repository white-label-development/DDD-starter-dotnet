﻿
# [*Domain building block*] Money

This view contains details information about Money building block, including:
- dependencies
- modules
- related processes  

---



## Domain Perspective


### Dependencies

```mermaid
  flowchart TB
    subgraph 0["Commons"]
      1(Money)
      class 1 DomainPerspective
    end
    subgraph 2["Commons"]
      3([Percentage])
      class 3 DomainPerspective
    end
    0-->|depends on|2
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

### Related process steps

Money is not used in any process step.  

## Next steps


### Zoom-out

- [[*Domain module*] Commons](../../../Modules/Sales/Commons/Commons.md)

### Change perspective

- [[*Domain building block*] Percentage](Percentage.md)

---

[P3 Model](https://github.com/P3-model/P3-model) documentation generated from source code using [.net tooling](https://github.com/P3-model/P3-model-dotnet)