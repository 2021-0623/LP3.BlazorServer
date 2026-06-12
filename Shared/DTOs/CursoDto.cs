using LP3.BlazorServer.Domain.Enums;

namespace LP3.BlazorServer.Shared.DTOs;

/// <summary>DTO para mostrar cursos en listados.</summary>
public class CursoDto
{
    public int Id { get; set; }
    public string Nombre   { get; set; } = string.Empty;
    public string Codigo   { get; set; } = string.Empty;   // Ej: "IRI-005"
    public int    Creditos { get; set; }
    public bool   Activo   { get; set; } = true;
}

/// <summary>DTO para crear o editar un curso.</summary>
public class CursoFormDto
{
    public int? Id { get; set; }  // null = crear nuevo
        public string Nombre   { get; set; } = string.Empty;
    public string Codigo   { get; set; } = string.Empty;   // Ej: "IRI-005"
    public int    Creditos { get; set; }
    public bool   Activo   { get; set; } = true;
}