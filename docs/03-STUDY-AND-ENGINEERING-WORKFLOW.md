# Study and Engineering Workflow

## Weekly allocation

### Normal week — 20 hours

| Activity | Hours |
|---|---:|
| Projects and practical exercises | 8 |
| LeetCode and data structures | 6 |
| Books and official documentation | 3 |
| English communication | 2 |
| Review and planning | 1 |

### Difficult week — 10 hours

| Activity | Hours |
|---|---:|
| Current project or lab | 4 |
| LeetCode review and practice | 3 |
| Documentation or book | 1 |
| English | 1 |
| Review and planning | 1 |

During a difficult week, do not start a major new technology. Finish a small existing task and preserve continuity.

## Sprint structure

Default sprint duration: 60 minutes.

Suggested format:

1. 5 minutes — define the objective and expected output.
2. 40 minutes — independent study or implementation.
3. 10 minutes — build, test, and inspect results.
4. 5 minutes — note what was learned and define the next action.

## Git workflow

1. Update `main`.
2. Create one focused branch.
3. Make one logical change at a time.
4. Build and test locally.
5. Inspect `git status` and `git diff`.
6. Commit with a clear English message.
7. Push the branch.
8. Open a pull request into `main`.
9. Link the related issue.
10. Review the complete diff.
11. Confirm checks or clearly document local validation.
12. Merge once.
13. Delete the feature branch.
14. Update issue checkboxes and progress notes.

### Branch examples

- `study/value-reference-types`
- `study/collections-generics`
- `test/stack-queue-exercises`
- `practice/two-pointer-problems`
- `feat/import-csv-transactions`
- `fix/duplicate-transaction-detection`
- `docs/update-project-readme`

### Commit examples

- `feat: add value and reference type examples`
- `test: cover empty stack behavior`
- `docs: explain collection selection`
- `fix: handle malformed transaction input`
- `chore: add repository editor configuration`

## Pull-request review criteria

- Branch direction is feature branch → `main`.
- Scope matches the issue.
- Commits are understandable.
- Code builds.
- Relevant tests pass.
- No generated or secret files are included.
- Documentation matches actual behavior.
- Technical explanations are accurate.
- The author can explain every meaningful change.
- Required issue criteria are completed.

## Definition of done

A feature or exercise is complete when:

- Acceptance criteria are met.
- Expected behavior works.
- Invalid input is considered.
- Important edge cases are covered.
- Relevant tests pass.
- The code builds without unexplained warnings.
- No secret or generated files are committed.
- The pull request is self-reviewed.
- Documentation is updated.
- The implementation can be explained without AI.

## AI usage rules

### Allowed immediately

- Concept explanations
- Documentation clarification
- Small syntax reminders
- One hint
- Code review
- Test-case brainstorming
- Comparison of approaches

### Requires an independent attempt

- Implementation suggestions
- Refactoring plans
- Debugging hypotheses
- Test implementations
- API designs
- Larger code examples

Before asking for substantial help, record:

- My current understanding
- What I tried
- The code involved
- My hypothesis
- The smallest blocker

### Prohibited during assessments

- Full generated implementation
- Generated architecture accepted without justification
- Tests copied without understanding
- Code that cannot be explained or modified
- AI-generated open-source contributions that are not understood

## LeetCode workflow

1. Attempt independently for up to 45 minutes.
2. Record attempted approaches.
3. Request one hint.
4. Continue for another 15–20 minutes.
5. Study a solution only after a serious attempt.
6. Reimplement without viewing the solution.
7. State time and space complexity.
8. Revisit after roughly two days.
9. Revisit again after one to two weeks.

## English workflow

Every week:

- Write repository content in English.
- Record or speak one technical explanation.
- Correct recurring communication errors.
- Gradually increase explanation length.

## Phase assessment rule

Phase assessments must be completed without AI-generated implementation code. AI may review the result after the assessment is declared complete.
