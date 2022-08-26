Imports System
Module Module1

    Sub Main()
        Dim a, b, c As Double
        Dim Opcion As Char = ""
        While Opcion <> "z"
            Console.Clear()
            Console.WriteLine("Problema 1.............(1)")
            Console.WriteLine("Problema 2.............(2)")
            Console.WriteLine("Problema 3.............(3)")
            Console.WriteLine("Problema 4.............(4)")
            Console.WriteLine("Problema 5.............(5)")
            Console.WriteLine("Opcion Salir...........(Z)")
            Try
                Opcion = Console.ReadKey.KeyChar
                Console.Clear()
                Select Case Opcion
                    Case "1"
                        Dim mayor, medio, menor As Double
                        Console.WriteLine("Problema 1")
                        Console.WriteLine("Ingrese primer numero: ")
                        a = Console.ReadLine()
                        Console.WriteLine("Ingrese Segundo numero: ")
                        b = Console.ReadLine()
                        Console.WriteLine("Ingrese Tercer numero: ")
                        c = Console.ReadLine()
                        If (a <= b) And (a <= c) Then
                            menor = a
                            If (b <= c) Then
                                medio = b
                                mayor = c
                            Else
                                medio = c
                                mayor = b
                            End If
                        End If
                        If (b <= a) And (b <= c) Then
                            menor = b
                            If (a <= c) Then
                                medio = a
                                mayor = c
                            Else
                                medio = c
                                mayor = a
                            End If
                        End If
                        If (c <= a) And (c <= b) Then
                            menor = c
                            If (a <= b) Then
                                medio = a
                                mayor = b
                            Else
                                medio = b
                                mayor = a
                            End If
                        End If
                        Console.WriteLine("Mayor: " & mayor)
                        Console.WriteLine("Medio: " & medio)
                        Console.WriteLine("Menor: " & menor)
                    Case "2"
                        Console.WriteLine("Problema 2")
                        Console.WriteLine("Ingrese primer numero: ")
                        a = Console.ReadLine()
                        Console.WriteLine("Ingrese segundo numero: ")
                        b = Console.ReadLine()
                        Console.WriteLine("Ingrese tercer numero: ")
                        c = Console.ReadLine()
                        If (a = b) And (a = c) Then
                            Console.WriteLine("El triangulo es EQUILATERO")
                        End If
                        If (a = b) Or (a = c) Or (c = b) Then
                            If (b <> c) Or (a <> b) Or (a <> c) Then
                                Console.WriteLine("El triangulo es ISOSELES")
                            End If
                        End If
                        If (a <> b) And (b <> c) Then
                            Console.WriteLine("El triangulo es ESCALENO ")
                        End If

                    Case "3"
                        Console.WriteLine("Problema 3")
                        Console.WriteLine("Ingrese primer numero: ")
                        a = Console.ReadLine()
                        Dim i As Integer
                        Console.WriteLine("Resultado")
                        For i = 0 To a Step 1
                            Console.WriteLine(i)

                        Next
                        Console.WriteLine("Suma de numeros: " & c)
                        If c Mod 2 = 0 Then
                            Console.WriteLine("La suma es PAR")
                        Else
                            Console.WriteLine("La suma es Impar")
                        End If
                        c = 0
                    Case "4"
                        Console.WriteLine("Problema 4")
                        Console.WriteLine("Ingrese un numero: ")
                        a = Console.ReadLine()
                        Dim i As Integer
                        Console.WriteLine("Resultado")
                        If a >= 0 Then
                            For i = 0 To a Step 2
                                Console.WriteLine(i)

                            Next
                        Else
                            For i = 0 To a Step -0.5
                                c = i - 0.5
                                Console.WriteLine(c)

                            Next
                        End If

                    Case "5"
                        Dim i As Double

                        Console.WriteLine("Problema 5")
                        Console.WriteLine("Ingrese nota de Matematica: ")
                        a = Console.ReadLine()
                        Console.WriteLine("Ingrese nota de Fisica: ")
                        b = Console.ReadLine()
                        Console.WriteLine("Ingrese nota de Programacion: ")
                        c = Console.ReadLine()

                        i = (a + b + c) / 3
                        Console.WriteLine("Resultado")
                        Console.WriteLine("El promedio es de: " & i.ToString)

                        If i < 61 Then
                            Console.WriteLine("Reprobado")
                        ElseIf (i >= 61 And i <= 80) Then
                            Console.WriteLine("Regular")
                        ElseIf (i > 80) Then
                            Console.WriteLine("Exelente")
                        End If


                    Case "z"
                        Console.Clear()
                        Console.WriteLine("Gracias por usar el programa de Jorge Pisquiy")
                    Case Else
                        Console.Clear()
                        Console.WriteLine("Opcion ingresada no es valida, vuelva a intentar")
                End Select

            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            If Opcion <> "z" Then Console.WriteLine("Pulse cualquier tecla para regresar al menu")
            Console.ReadKey()
        End While
    End Sub

End Module
