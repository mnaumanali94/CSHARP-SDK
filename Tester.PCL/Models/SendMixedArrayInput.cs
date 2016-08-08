/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 08/08/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tester.PCL.Http.Client;
using Tester.PCL;

namespace Tester.PCL.Models
{
    public class SendMixedArrayInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private FileStreamInfo file;
        private List<int> integers;
        private List<Employee> models;
        private List<string> strings;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("file")]
        public FileStreamInfo File 
        { 
            get 
            {
                return this.file; 
            } 
            set 
            {
                this.file = value;
                onPropertyChanged("File");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("integers")]
        public List<int> Integers 
        { 
            get 
            {
                return this.integers; 
            } 
            set 
            {
                this.integers = value;
                onPropertyChanged("Integers");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("models")]
        public List<Employee> Models 
        { 
            get 
            {
                return this.models; 
            } 
            set 
            {
                this.models = value;
                onPropertyChanged("Models");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("strings")]
        public List<string> Strings 
        { 
            get 
            {
                return this.strings; 
            } 
            set 
            {
                this.strings = value;
                onPropertyChanged("Strings");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 