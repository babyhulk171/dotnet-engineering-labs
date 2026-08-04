# Backend-First Full-Stack .NET Engineering Roadmap

**Start date:** August 10, 2026  
**Target application date:** February 2028  
**Normal workload:** 20 hours per week  
**Minimum viable workload:** 10 hours per week  
**Primary target:** Remote full-stack .NET positions  
**Secondary target:** General software-engineering positions  
**Stack:** C# 14, .NET 10, ASP.NET Core, PostgreSQL, React, and TypeScript

---

## 1. Current Position

I am not a complete beginner programmer. I already have two years of production experience involving:

- Daily work in a large legacy Java 7 system
- Independent bug investigation
- Feature implementation
- PostgreSQL and manual SQL
- Debugging with breakpoints
- Navigating classes with hundreds or thousands of lines
- Maintaining software with real users and business rules

The main areas missing from my current professional environment are:

- Automated tests
- Pull requests and code review
- CI/CD
- Modern application architecture
- Safe refactoring
- API development
- Deployment
- Containers
- Observability
- Independent feature design
- English technical communication

This roadmap must therefore teach two things simultaneously:

1. Modern .NET development
2. The engineering workflow missing from my current job

By February 2028, I should be able to take a written requirement and independently:

1. Clarify its business rules
2. Divide it into technical tasks
3. Design the data model and API
4. Implement the backend and frontend
5. Write automated tests
6. Use Git branches and pull requests
7. Configure CI
8. Containerize and deploy the application
9. Diagnose production-style failures
10. Explain my decisions in English

---

## 2. Weekly Study System

### Normal 20-hour week

| Activity | Hours |
|---|---:|
| Building projects | 8 |
| LeetCode and data structures | 6 |
| Reading books and documentation | 3 |
| English communication practice | 2 |
| Weekly review and planning | 1 |

A possible distribution:

| Day | Sprint 1 | Sprint 2 | Sprint 3 | Sprint 4 | Sprint 5 |
|---|---|---|---|---|---|
| Monday | LeetCode | LeetCode review | Project | Project | Documentation |
| Tuesday | Project | Project | C#/.NET exercise | English | Reading |
| Wednesday | LeetCode | LeetCode review | Project | Project | Testing |
| Thursday | LeetCode | Project | Project | English | Weekly review |

Study in one-hour sprints with meaningful breaks. Avoid running all sprints continuously.

### Difficult 10-hour week

| Activity | Hours |
|---|---:|
| Main project | 4 |
| LeetCode | 3 |
| Documentation or book | 1 |
| English | 1 |
| Review and planning | 1 |

During difficult weeks:

- Do not begin a new technology
- Continue the current feature
- Review previously solved algorithm problems
- Complete one small pull request
- Preserve the study habit instead of overcompensating later

---

## 3. Eighteen-Month Roadmap

Dates are deadlines, but every phase also has a completion gate. A phase may be extended by one or two weeks when necessary, but major gaps should not be ignored.

---

## Phase 1 — Modern C# Foundations

**August–October 2026**

### Month 1: August 10–September 6

Study:

- Value types and reference types
- Classes, records, structs, and enums
- Collections
- Generics
- Nullable reference types
- Exceptions
- Debugging
- Git branches and small commits
- xUnit basics

Deliverables:

- Public exercises repository
- At least four feature branches and pull requests
- Small programs demonstrating each C# concept
- Unit tests using Arrange–Act–Assert
- English README and commit messages

### Month 2: September 7–October 4

Study:

- Lambdas
- Delegates
- LINQ
- Files and streams
- JSON serialization
- Composition versus inheritance
- SOLID fundamentals
- Test cases and edge cases
- Git merge, rebase, stash, revert, and reflog

Begin Project 1: **Expense Importer CLI**.

### Month 3: October 5–November 1

Study:

- `async` and `await`
- `Task` and `Task<T>`
- Cancellation tokens
- `HttpClient`
- Dependency injection
- Application configuration
- Basic memory management
- HTTP request/response fundamentals
- Refactoring

Complete Project 1 and begin a small ASP.NET Core API without a database.

### Phase 1 Gate

I must be able to create a C# solution from an empty directory and independently implement:

- File and JSON processing
- Collections and LINQ
- An asynchronous external API call
- Cancellation and error handling
- Dependency injection
- Unit tests
- A professional Git workflow

I must also explain every line of the submitted project without AI assistance.

---

## Phase 2 — ASP.NET Core and Relational Backend Development

**November 2026–January 2027**

### Month 4: November 2–November 29

Study:

- HTTP methods, headers, and status codes
- REST resource design
- Controller-based APIs
- Routing
- Model binding
- Dependency injection
- Middleware
- DTOs
- Request validation
- Centralized error handling
- OpenAPI

Begin Project 2: **Personal Finance API**.

### Month 5: November 30–December 27

Study:

- Entity Framework Core
- PostgreSQL integration
- Entities and relationships
- Migrations
- Constraints
- Normalization
- Transactions
- CTEs and window functions
- Index fundamentals
- SQL injection prevention

### Month 6: December 28–January 31

Study:

- Unit versus integration testing
- ASP.NET Core integration tests
- Realistic test data
- Authentication fundamentals
- Authorization fundamentals
- Docker basics
- Docker Compose
- GitHub Actions
- Application deployment

Complete and deploy Project 2.

### Phase 2 Gate

From an empty directory, build an API that includes:

- Controller-based endpoints
- PostgreSQL
- EF Core migrations
- Validation
- Correct HTTP status codes
- Pagination and filtering
- Unit tests
- Integration tests
- OpenAPI documentation
- Docker Compose
- CI build and test workflow
- Public deployment

I must be able to trace:

```text
HTTP request
→ middleware
→ controller
→ application logic
→ EF Core
→ PostgreSQL
→ response
```

---

## Phase 3 — Production-Style Backend Engineering

**February–April 2027**

### Month 7: February

Study:

- Structured logging
- Configuration environments
- Secret management
- Health checks
- Problem Details error responses
- Database backup and restore
- Execution plans
- Indexes
- `EXPLAIN`
- Query optimization

### Month 8: March

Study:

- Authentication versus authorization
- Cookie and token authentication
- Role-based authorization
- Policy-based authorization
- Password hashing
- File uploads
- Search
- Audit history

Begin Project 3: **Postgraduate Application Portal**.

### Month 9: April

Study:

- Email notifications
- Background services
- Retry strategies
- Idempotency
- Rate limiting
- External services
- Audit logging
- Deployment configuration
- CI/CD improvements

Deploy the backend portion of Project 3.

### Phase 3 Gate

The backend must support:

- Multiple user roles
- Authentication and authorization
- Status transitions governed by business rules
- File uploads
- Search
- Audit records
- Background processing
- Structured logs
- Health endpoint
- Database backup instructions
- Automated deployment or a completely documented deployment process

---

## Phase 4 — TypeScript and React Full-Stack Development

**May–July 2027**

### Month 10: May

Study:

- Modern JavaScript fundamentals
- TypeScript types and interfaces
- Modules
- Promises
- DOM and browser events
- Network tools in browser developer tools
- React components
- Props
- State
- Events

### Month 11: June

Study:

- React forms
- Client-side validation
- Routing
- API consumption
- Authentication state
- Loading and error states
- Reusable components
- Basic accessibility
- Component testing fundamentals

Do not spend significant time on advanced CSS. Use simple layouts and a small component library when useful. The objective is functional full-stack development, not visual design specialization.

### Month 12: July

Complete the frontend of Project 3.

Required frontend features:

- Login
- Role-dependent navigation
- Application form
- File submission
- Search and filters
- Status history
- Administrative review
- Clear loading and error feedback

Add a small number of end-to-end tests and record an English demonstration video.

### Phase 4 Gate

I must be able to:

- Create a React and TypeScript application from scratch
- Consume my ASP.NET Core API
- Handle authentication
- Build forms and validation
- Diagnose requests using browser developer tools
- Deploy the frontend and backend
- Explain the complete application in English for 10–15 minutes

---

## Phase 5 — Architecture, Performance, and System Design

**August–October 2027**

### Month 13: August

Study:

- Separation of concerns
- Layered architecture
- Dependency inversion
- Application, domain, and infrastructure responsibilities
- DTOs versus entities
- Mapping
- Modular monoliths
- Architecture diagrams
- Architecture Decision Records

Do not adopt a large Clean Architecture template automatically. First learn why each boundary exists and which problem it solves.

Create:

- System context diagram
- Container diagram
- Component diagram
- Sequence diagram for one important request
- Two Architecture Decision Records

### Month 14: September

Study:

- Transactions and isolation
- Race conditions
- Optimistic concurrency
- Caching
- Database indexes
- Query plans
- Performance profiling
- Memory fundamentals
- Availability and reliability

Run simple performance experiments and document results instead of attempting premature optimization.

### Month 15: October

Project 4: **Developer Release Monitor**

Study and implement:

- External API consumption
- Scheduled background processing
- Cancellation
- Retry and timeout policies
- Rate-limit handling
- Caching
- Notifications
- Idempotency
- Structured logs
- Health checks

A message broker may be introduced only after the initial modular monolith works. Do not split the application into microservices merely to claim microservices experience.

### Phase 5 Gate

Given a normal business-system requirement, I must be able to explain:

- Component boundaries
- Database design
- Security approach
- Testing strategy
- Deployment design
- Likely bottlenecks
- Failure scenarios
- Scaling options
- Trade-offs

I should also be able to explain why a modular monolith may be preferable to microservices for a small team.

---

## Phase 6 — Open Source and Job Preparation

**November 2027–January 2028**

### Month 16: November

- Identify active .NET open-source repositories
- Read contribution instructions
- Build one project locally
- Submit a documentation, test, or small bug-fix contribution
- Improve all portfolio READMEs
- Add diagrams and screenshots
- Clean commit histories where appropriate
- Create tagged releases using Semantic Versioning

### Month 17: December

- Begin weekly live-coding simulations
- Practise API and database interview questions
- Practise explaining projects in English
- Complete behavioral interview stories
- Study practical system-design questions
- Review C#, ASP.NET Core, SQL, and testing
- Prepare CV and LinkedIn material

### Month 18: January 2028

- Complete three full mock interviews
- Complete two timed take-home simulations
- Perform portfolio review against job descriptions
- Apply to several lower-risk positions as interview practice
- Fix weaknesses revealed by interviews
- Prepare a repeatable application-tracking system

### February 2028 onward

Begin consistent applications to:

- Remote Brazilian positions
- Employer-of-record international positions
- Remote public-sector technology contractors where compatible
- Consultancies and outsourcing companies
- Established product companies

Do not restrict applications to jobs where every listed requirement is already satisfied.

---

## 4. First 12 Weeks

### Week 1 — Environment and Workflow

- Create a public `dotnet-engineering-labs` repository
- Add a README explaining the roadmap in English
- Create issues for the first four weeks
- Work only through feature branches
- Open a pull request for every exercise group
- Review value types and reference types
- Practise enums and records
- Solve array and hash-map problems
- Record a two-minute English introduction

### Week 2 — Collections and Generics

- Study `List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>`, `Queue<T>`, and `Stack<T>`
- Implement small versions of a stack and queue
- Write generic helper methods
- Compare arrays, lists, dictionaries, and sets
- Write unit tests for all exercises
- Practise hash-map and set LeetCode problems

### Week 3 — Lambdas and LINQ

- Study delegates and lambdas
- Use `Where`, `Select`, `Any`, `All`, `OrderBy`, `GroupBy`, and `ToDictionary`
- Rewrite imperative collection code using LINQ
- Explain when the LINQ version is less readable
- Practise two-pointer problems

### Week 4 — Errors and Test Design

- Study nullable reference types
- Create custom exceptions only where justified
- Test exceptions and invalid inputs
- Learn facts versus theories in xUnit
- Write edge-case lists before implementation
- Practise sliding-window problems
- Complete the first phase checkpoint

### Week 5 — Object Design

- Study composition
- Review single responsibility and dependency inversion
- Identify code smells in deliberately poor sample code
- Refactor a large class into focused collaborators
- Design Project 1
- Write its requirements and acceptance criteria

### Week 6 — Files and JSON

- Read and write text files
- Work with streams
- Deserialize JSON into records
- Validate imported data
- Handle malformed files
- Begin Expense Importer CLI

### Week 7 — Asynchronous Programming

- Study tasks and asynchronous I/O
- Use `HttpClient`
- Add cancellation
- Handle timeouts and non-success responses
- Add an optional exchange-rate or categorization integration
- Practise binary-search problems

### Week 8 — Complete Project 1

- Finish features
- Add unit tests
- Improve error messages
- Add logging
- Write usage documentation
- Perform self-review through a pull request
- Tag version `1.0.0`
- Record a five-minute English demonstration

### Week 9 — HTTP and ASP.NET Core

- Create a controller-based API
- Learn routing and status codes
- Use browser tools and an API client
- Implement in-memory CRUD
- Draw the request lifecycle

### Week 10 — Dependency Injection and Configuration

- Extract application services
- Register dependencies
- Use configuration options
- Create development and production settings
- Store development secrets safely
- Test service classes

### Week 11 — API Quality

- Add validation
- Add centralized exception handling
- Return Problem Details
- Add pagination and filtering
- Generate OpenAPI documentation
- Write negative-path tests

### Week 12 — API Assessment

Without copying a tutorial, implement a small API containing:

- At least three resources
- One parent-child relationship
- Validation
- Correct error responses
- Dependency injection
- Unit tests
- Integration tests
- OpenAPI
- CI

No AI-generated implementation code is allowed during the final assessment.

---

## 5. Portfolio Project Specifications

### Project 1 — Expense Importer CLI

**Purpose:** Demonstrate modern C# fundamentals.

Features:

- Import CSV and JSON transactions
- Validate fields
- Detect duplicates
- Categorize transactions
- Filter and group data
- Generate monthly summaries
- Export results
- Asynchronous optional external API call
- Cancellation support
- Clear error messages
- Unit tests

Skills demonstrated:

- C#
- Collections
- Generics
- LINQ
- Records
- Files
- JSON
- Async programming
- Testing
- Git workflow

**Target duration:** Four weeks

---

### Project 2 — Personal Finance API

**Purpose:** Demonstrate employable .NET backend fundamentals.

Entities:

- User
- Account
- Category
- Transaction
- Monthly budget

Features:

- CRUD endpoints
- PostgreSQL
- EF Core migrations
- Relational constraints
- Pagination
- Filtering
- Monthly summaries
- Validation
- Error handling
- OpenAPI
- Unit and integration tests
- Docker Compose
- CI
- Public deployment

**Target duration:** Three months

---

### Project 3 — Postgraduate Application Portal

**Purpose:** Demonstrate full-stack development and complex business rules without copying SIGAA.

Roles:

- Applicant
- Reviewer
- Administrator

Features:

- Registration and authentication
- Authorization policies
- Application periods
- Application submission
- Required-document uploads
- Review assignments
- Status transitions
- Search and filtering
- Audit history
- Email notifications
- Background tasks
- Reports
- React and TypeScript frontend
- End-to-end tests
- Production deployment

**Target duration:** Five months

---

### Project 4 — Developer Release Monitor

**Purpose:** Demonstrate integrations and production resilience.

Features:

- Track selected software repositories
- Poll an external API for releases
- Scheduled background worker
- Retry and timeout handling
- Rate-limit handling
- Caching
- User notifications
- Idempotent processing
- Health checks
- Structured logs
- Metrics
- Optional queue introduced late

**Target duration:** Two to three months

---

## 6. LeetCode Curriculum

Six hours per week is acceptable because algorithm interviews are part of the target and the practice is enjoyable. The goal is not raw problem count. The goal is recognition, retention, and explanation.

### Weekly algorithm routine

- Two hours: new problems
- Two hours: previously solved problems without notes
- One hour: study one pattern
- One hour: timed problem or verbal explanation

Use this help sequence:

1. Work independently for 45 minutes
2. Write what I tried
3. Request one hint
4. Continue for another 15–20 minutes
5. Read a solution only after making a serious attempt
6. Close the solution and reimplement it
7. Repeat after two days
8. Repeat after one or two weeks

### Months 1–3

- Arrays
- Strings
- Hash maps
- Sets
- Two pointers
- Sliding windows
- Stacks
- Queues
- Binary search

### Months 4–6

- Linked lists
- Recursion
- Trees
- Binary search trees
- Breadth-first search
- Depth-first search
- Heaps

### Months 7–12

- Graphs
- Backtracking
- Intervals
- Greedy algorithms
- One-dimensional dynamic programming
- Basic two-dimensional dynamic programming

### Months 13–18

- Mixed medium problems
- Timed interview sets
- Verbal complexity analysis
- Mock interviews
- Weak-pattern review

### Target by February 2028

- Approximately 150–180 unique problems
- Most important problems solved at least twice
- Majority of later problems at medium difficulty
- Ability to explain time and space complexity verbally
- Ability to recognize common patterns without immediately asking AI

---

## 7. English Integration

Allocate two hours per week from the first week.

### Mandatory English habits

- All public READMEs in English
- All commit messages in English
- All issues and pull requests in English
- Architecture documentation in English
- Demonstration videos in English

### Weekly rotation

- One hour: technical writing
- One hour: speaking and listening

Speaking exercises:

- Explain one class without reading code
- Explain a bug and how it was diagnosed
- Explain why a database relationship was chosen
- Explain a failed approach
- Explain a pull-request diff
- Answer one behavioral question

Progression:

- Month 1: two-minute recordings
- Month 3: five-minute project explanation
- Month 6: ten-minute backend walkthrough
- Month 9: answer common interview questions
- Month 12: full project demonstration
- Month 15: technical mock interview
- Months 16–18: weekly mock interviews

Do not wait for fluent spoken English before speaking. Technical reading is already strong enough to use English resources directly.

---

## 8. AI Usage Rules

AI remains available, but it must not replace engineering decisions.

### Allowed immediately

- Explaining documentation
- Clarifying error messages
- Giving a small hint
- Reviewing a plan
- Suggesting test scenarios
- Reviewing code already written
- Comparing alternatives
- Creating practice questions

### Allowed only after an independent attempt

- Boilerplate
- Refactoring suggestions
- Example tests
- Debugging hypotheses
- API design alternatives

Before asking AI, provide:

1. My understanding of the problem
2. What I tried
3. The relevant code
4. My current hypothesis
5. The smallest question that would unblock me

### Not allowed

- Generating an entire feature before designing it
- Copying code I cannot explain
- Asking AI to complete phase assessments
- Accepting architecture solely because AI recommended it
- Using generated tests without verifying what they protect
- Submitting AI-generated open-source contributions I do not understand

### AI verification rule

For every significant generated section, I must be able to:

- Explain it
- Modify it
- Test it
- Identify at least one failure condition
- Reproduce the key idea later without AI

Maintain an `AI-usage.md` file recording important cases where AI helped and what was learned.

---

## 9. Git and Professional Workflow

Every portfolio feature follows this sequence:

1. Create an issue
2. Write the problem and acceptance criteria
3. Break it into small tasks
4. Create a branch
5. Commit logical increments
6. Add tests
7. Push the branch
8. Open a pull request
9. Review the diff
10. Wait briefly before the final review
11. Confirm CI passes
12. Merge
13. Delete the branch
14. Update documentation when necessary

Commit throughout development rather than only after finishing the entire feature.

Practise these recovery operations in a disposable repository:

- Restore an uncommitted file
- Revert a pushed commit
- Recover a deleted branch
- Recover a commit using reflog
- Resolve a merge conflict
- Rebase a short branch
- Abort a failed rebase
- Cherry-pick a commit
- Stash partial work

---

## 10. Definition of Done

A feature is not complete merely because the successful manual scenario works.

A portfolio feature is complete when:

- Acceptance criteria are satisfied
- Invalid input is handled
- Important edge cases are tested
- Business rules have unit tests
- Infrastructure behavior has integration tests
- Logs support diagnosis
- Secrets are not committed
- CI passes
- The pull request has been reviewed
- Documentation is updated
- Database changes use migrations
- The deployed application still works
- I can explain the implementation

Do not target arbitrary test-coverage percentages. Use coverage reports to find untested important behavior, not to maximize a number.

---

## 11. Phase Assessments

Assessments occur at the end of each phase and should be completed without implementation assistance from AI.

### Phase 1 Assessment

Build a complete CLI from written requirements in one week.

### Phase 2 Assessment

Build and deploy a tested PostgreSQL-backed API.

### Phase 3 Assessment

Add secure role-based functionality, file upload, and background processing to an application.

### Phase 4 Assessment

Build and deploy a functional React frontend for an existing API.

### Phase 5 Assessment

Design a production-style business system and defend its architecture and trade-offs.

### Phase 6 Assessment

Complete:

- One live-coding interview
- One system-design interview
- One behavioral interview
- One project presentation
- One timed take-home assignment

---

## 12. Progress Measurements

### Track weekly

- Study hours
- Planned versus completed tasks
- Pull requests merged
- Features completed
- Important behaviors covered by tests
- LeetCode problems solved
- LeetCode problems revisited
- English speaking practice
- Topics requiring review

### Track monthly

- One retrospective
- One project demonstration
- One code-quality review
- One GitHub profile review
- One English self-assessment
- One algorithm-pattern assessment

### Monthly retrospective questions

1. What can I now do without assistance?
2. Where did AI do too much of the work?
3. Which concept still feels memorized rather than understood?
4. Which feature produced the most learning?
5. What caused fatigue or boredom?
6. What should be removed from next month?
7. What visible portfolio result did I produce?

---

## 13. Resource Strategy

### Free primary resources

Use official documentation before random video courses:

- [Microsoft .NET Training](https://learn.microsoft.com/en-us/training/dotnet/)
- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [ASP.NET Core Fundamentals](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/)
- [ASP.NET Core Web API Tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api)
- [Entity Framework Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
- [EF Core Migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/)
- [PostgreSQL Tutorial](https://www.postgresql.org/docs/current/tutorial.html)
- [PostgreSQL SQL Documentation](https://www.postgresql.org/docs/current/sql.html)
- [xUnit Documentation](https://xunit.net/docs/getting-started/v3/getting-started)
- [Docker Get Started](https://docs.docker.com/get-started/)
- [GitHub Actions for .NET](https://docs.github.com/en/actions/use-cases-and-examples/building-and-testing/building-and-testing-net)
- [TypeScript Handbook](https://www.typescriptlang.org/docs/handbook/intro.html)
- [React Learn](https://react.dev/learn)

### Books worth purchasing

#### First purchase: *Learning Git* — Anna Skoulikari

Read during Months 1–3.

Focus on:

- Git’s data model
- Commits
- Branches
- Merging
- Remotes
- Pull requests

#### Second purchase: *C# in Depth, Fourth Edition* — Jon Skeet

Begin after becoming comfortable with basic syntax. Use it for language depth, not as a complete C# 14 reference.

#### Third purchase: *ASP.NET Core in Action, Third Edition* — Andrew Lock

Use from Phase 2 onward.

#### Optional later purchase: *Clean Code, Second Edition*

Read after writing enough code to evaluate the advice critically. Treat its principles as ideas to test, not unquestionable laws.

Do not read four books simultaneously. Maintain one primary book and consult documentation while building.

---

## 14. Certifications

Certifications are secondary to deployed projects.

### Recommended Checkpoint 1

**Foundational C# Certification from Microsoft and freeCodeCamp**

Complete near the end of Phase 1. It should not delay Project 1.

### Optional Checkpoint 2

**GitHub Foundations**

Consider after Phase 2 because Git and collaboration workflow are currently weak.

### Optional Checkpoint 3

**GitHub Actions**

Consider only after configuring CI/CD in multiple projects.

### Cloud Certification

Reassess cloud credentials in late 2027, after gaining practical deployment experience. Do not prioritize a cloud certification before being able to independently build and deploy complete applications.

---

## 15. Interview-Readiness Criteria

Begin serious applications when most of these statements are true.

### C# and .NET

- Build normal C# applications without tutorials
- Explain generics, collections, LINQ, exceptions, and nullability
- Write asynchronous code with cancellation
- Explain value and reference types
- Diagnose common runtime errors
- Review AI-generated code critically

### Backend

- Design a REST API
- Build controllers, services, and data access
- Use PostgreSQL and EF Core
- Write migrations
- Use transactions and constraints
- Implement validation and error handling
- Implement authentication and authorization
- Write unit and integration tests
- Add logs and health checks

### Frontend

- Build React components with TypeScript
- Manage forms and client-side validation
- Consume APIs
- Handle authentication
- Diagnose browser network problems
- Build functional responsive layouts

### Workflow and Deployment

- Work with branches and pull requests
- Resolve conflicts
- Recover lost Git work
- Configure CI
- Use Docker and Compose
- Manage configuration and secrets
- Deploy frontend, backend, and database
- Diagnose a failed deployment

### Architecture

- Explain request flow through the application
- Separate UI, application, domain, and infrastructure responsibilities
- Explain a modular monolith
- Discuss caching, queues, scaling, and availability
- Identify trade-offs instead of naming patterns without justification

### Interviews

- Solve common easy problems reliably
- Solve selected medium problems in approximately 30–45 minutes
- Explain complexity
- Complete a small take-home project professionally
- Present a project in English
- Answer behavioral questions using real work examples
- Complete a junior-level system-design discussion

---

## 16. Immediate Objective

The first milestone is not “learn all of C#.”

By **November 1, 2026**, I should have:

- A public C# project
- A complete CLI application
- Unit tests
- English documentation
- Feature branches
- Pull requests
- CI
- A tagged release
- A demonstration video
- The ability to rebuild its core functionality without AI

That visible result will address the current problems of unfinished projects, unclear next steps, dependence on AI, and lack of public evidence.
