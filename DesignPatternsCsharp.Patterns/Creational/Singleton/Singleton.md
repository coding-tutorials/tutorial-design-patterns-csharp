Singleton
===
- Only one instance is created, and this guarantees the control of a resource, making a global access for the object instance.

Design
===
- Private constructor (only the Singleton itself call the private constructor)
- The instance will be provided by a static public method
- The instance will be lazy-loaded
- Needs to be thread safe
- No parameters required for construction (required parameters will transform Singleton to a Factory)
