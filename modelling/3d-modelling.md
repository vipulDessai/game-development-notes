# **3D Modelling**

# Sub divisions levels

| Subdiv Level | Polycount (approx.) |
| ------------ | ------------------- |
| 0            | (Base) 24,000       |
| 1            | 96,000              |
| 2            | 384,000             |
| 3            | 1.54M               |
| 4            | 6.14M               |
| 5            | 24.6M               |
| 6            | 98.3M ✅            |

# Workflows

1. polygroup so that the edgeloops around mouth, ear, eyes are preserved
2. Duplicate the subtool as source mesh
3. retope the target subtool with zremesher to 25k or 95k
4. project the target subtool to source subtool
   - the project all should be run on source subtool
5. sculpt all the way to 100M
