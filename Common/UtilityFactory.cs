using Common.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class UtilityFactory
    {
        #region "Local"
        private FunctionUtility _functionUtility = new FunctionUtility();
        private DateTimeUtility _dateTimeUtility = new DateTimeUtility();
        private ExceptionUtility _exceptionUtility = new ExceptionUtility();
        private HexUtility _hexUtility = new HexUtility();
        private NumberUtility _numberUtility = new NumberUtility();
        private ReflectionUtility _reflectionUtility = new ReflectionUtility();
        private SerializeUtility _serializeUtility = new SerializeUtility();
        private StringUtility _stringUtility = new StringUtility();
        #endregion "Local"

        #region "Constructor"

        private static UtilityFactory _instance;

        /// <summary>
        /// Private Constructor
        /// </summary>
        private UtilityFactory()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static UtilityFactory Instance()
        {
            if (_instance == null)
            {
                _instance = new UtilityFactory();
            }
            return _instance;
        }

        #endregion "Constructor"

        #region "Property"
        public FunctionUtility FunctionUtility { get { return _functionUtility; } }
        public DateTimeUtility DateTimeUtility { get { return _dateTimeUtility; } }
        public ExceptionUtility ExceptionUtility { get { return _exceptionUtility; } }
        public HexUtility HexUtility { get { return _hexUtility; } }
        public NumberUtility NumberUtility { get { return _numberUtility; } }
        public ReflectionUtility ReflectionUtility { get { return _reflectionUtility; } }
        public SerializeUtility SerializeUtility { get { return _serializeUtility; } }
        public StringUtility StringUtility { get { return _stringUtility; } }
        #endregion
    }
}
