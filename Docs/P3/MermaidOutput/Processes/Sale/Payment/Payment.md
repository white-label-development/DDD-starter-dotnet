﻿
# [*Business process*] Payment

This view contains details information about Payment business process, including:
- other related processes
- process steps
- related domain modules
- related deployable units
- engaged people: actors, development teams, business stakeholders  

---



## Domain Perspective


### Related processes and steps

```mermaid
  flowchart TB
    0(Payment)
    class 0 DomainPerspective
    1([Sale])
    class 1 DomainPerspective
    1---0
    1-->|is part of|0
    0---1
    2([RequestPayment])
    class 2 DomainPerspective
    0-->|contains|2
    linkStyle 0,2 stroke:none
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

### Related modules

```mermaid
  flowchart TB
    0(Payment)
    class 0 DomainPerspective
    1([Payments])
    class 1 DomainPerspective
    0-->|belongs to|1
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

## Technology Perspective


### Related deployable units

```mermaid
  flowchart TB
    0(Payment)
    class 0 DomainPerspective
    1([ecommerce-monolith])
    class 1 TechnologyPerspective
    0-->|is deployed in|1
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

## People Perspective


### Engaged people

```mermaid
  flowchart LR
    subgraph 0["Actors"]
      direction TB
    end
    1(Payment)
    class 1 DomainPerspective
    0-->|uses|1
    subgraph 2["Teams"]
      direction TB
      3([Supporting team])
      class 3 PeoplePerspective
    end
    2---1
    2-->|develops & maintains|1
    1---2
    subgraph 4["Business"]
      direction TB
      5([Sales department])
      class 5 PeoplePerspective
    end
    4---1
    4-->|owns|1
    1---4
    linkStyle 1,3,4,6 stroke:none
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

## Next steps


### Zoom-in

- [[*Process Step*] RequestPayment](../../../ProcessSteps/Sale/Payment/RequestPayment.md)

### Zoom-out

- [Business processes](../../../Business_Processes.md)

### Change perspective

- [[*Business organizational unit*] Sales department](../../../BusinessOrganizationalUnits/Sales department.md)
- [[*Deployable unit*] ecommerce-monolith](../../../DeployableUnits/ecommerce-monolith.md)
- [[*Development team*] Supporting team](../../../Teams/Supporting team.md)
- [[*Process Step*] RequestPayment](../../../ProcessSteps/Sale/Payment/RequestPayment.md)

---

[P3 Model](https://github.com/P3-model/P3-model) documentation generated from source code using [.net tooling](https://github.com/P3-model/P3-model-dotnet)