namespace OdooSharp.Configuration
{
    /// <summary>
    /// Represents common RPC methods used with the Odoo "object" service.
    /// </summary>
    public enum OdooMethod
    {
        /// <summary>
        /// Reads specific fields from existing records by ID.
        /// Equivalent to calling `read(record_ids, fields)`.
        /// </summary>
        read,

        /// <summary>
        /// Combines a search and a read operation.
        /// Returns a list of records matching a domain filter.
        /// Equivalent to calling `search(domain)` followed by `read(ids, fields)`.
        /// </summary>
        search_read,

        /// <summary>
        /// Counts the number of records matching a domain filter.
        /// Equivalent to calling `search_count(domain)`.
        /// </summary>
        search_count,

        /// <summary>
        /// Creates a new record in the given model.
        /// Equivalent to calling `create(field_values)`.
        /// </summary>
        create,

        /// <summary>
        /// Updates one or more existing records by ID.
        /// Equivalent to calling `write(record_ids, updated_field_values)`.
        /// </summary>
        write,

        /// <summary>
        /// Deletes one or more records by ID.
        /// Equivalent to calling `unlink(record_ids)`.
        /// </summary>
        unlink,

        /// <summary>
        /// Returns metadata about the fields of a model.
        /// Useful for dynamic code generation or schema inspection.
        /// Equivalent to calling `fields_get()`.
        /// </summary>
        fields_get
    }
}
