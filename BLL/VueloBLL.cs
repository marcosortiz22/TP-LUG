﻿using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace BLL
{
    public class VueloBLL
    {
        private readonly VueloData _vueloData;

        public VueloBLL()
        {
            _vueloData = new VueloData();
        }

        public void CrearVuelo(Vuelo vuelo)
        {
            try
            {
                ValidarVuelo(vuelo);
                using (var trx = new TransactionScope())
                {
                    // Actualizar el saldo de horas del cliente y la revisión del avión
                    vuelo.ClientVuelo.SaldoHoras += vuelo.TV;
                    vuelo.AeronaveVuelo.Revision100Hs += vuelo.TV;

                    _vueloData.AgregarVuelo(vuelo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el vuelo: " + ex.Message, ex);
            }
        }

        public Vuelo ObtenerVueloPorId(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("El ID del vuelo debe ser un número positivo.");
                }

                var vuelo = _vueloData.ObtenerVueloPorId(id);

                if (vuelo == null)
                {
                    throw new Exception("Vuelo no encontrado.");
                }

                return vuelo;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el vuelo por ID: " + ex.Message, ex);
            }
        }

        public List<Vuelo> ObtenerTodosLosVuelos()
        {
            try
            {
                return _vueloData.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de vuelos: " + ex.Message, ex);
            }
        }

        public void ActualizarVuelo(Vuelo vuelo)
        {
            try
            {
                if (vuelo == null || vuelo.Cod_Vuelo <= 0)
                {
                    throw new ArgumentException("El vuelo no es válido para la actualización.");
                }

                ValidarVuelo(vuelo);

                _vueloData.ActualizarVuelo(vuelo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el vuelo: " + ex.Message, ex);
            }
        }

        public void EliminarVuelo(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("El ID del vuelo debe ser un número positivo.");
                }

                _vueloData.EliminarVuelo(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el vuelo: " + ex.Message, ex);
            }
        }

        private void ValidarVuelo(Vuelo vuelo)
        {
            if (vuelo == null)
            {
                throw new ArgumentNullException(nameof(vuelo), "El vuelo no puede ser nulo.");
            }

            if (vuelo.FechaVuelo == default)
            {
                throw new ArgumentException("La fecha del vuelo no puede estar vacía.");
            }

            if (vuelo.ClientVuelo == null)
            {
                throw new ArgumentException("Debe asignarse un cliente al vuelo.");
            }

            if (vuelo.InstructorVuelo == null && vuelo.ClientVuelo.Brevet == null)
            {
                throw new ArgumentException("Debe existir una persona capaz de pilotar (cliente con brevet o instructor).");
            }

            if (vuelo.AeronaveVuelo == null)
            {
                throw new ArgumentException("Debe asignarse una aeronave al vuelo.");
            }

            if (vuelo.HubFinal <= vuelo.HubInicial)
            {
                throw new ArgumentException("El HUB final debe ser mayor al inicial.");
            }

            if (vuelo.TV <= 0)
            {
                throw new ArgumentException("El tiempo de vuelo (TV) debe ser mayor a cero.");
            }
        }
    }
}
