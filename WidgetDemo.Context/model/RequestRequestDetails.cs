using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemo.Context.model
{
    /// <summary>
    /// 请求明细
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class RequestDetails
    {
        private RequestRequestDetailsAddBookingRequest addBookingRequestField;

        private RequestRequestDetailsModifyBookingRequest modifyBookingRequestField;

        private RequestRequestDetailsCancelBookingRequest cancelBookingRequestField;

        private RequestRequestDetailsSearchBookingRequest searchBookingRequestField;

        private RequestRequestDetailsAddBookingItemRequest addBookingItemRequestField;

        private object modifyBookingItemRequestField;

        private object cancelBookingItemRequestField;

        private object searchBookingItemRequestField;

        /// <remarks/>
        public AddBookingRequestDetail AddBookingRequest        {            get;            set;        }

        /// <remarks/>
        public RequestRequestDetailsModifyBookingRequest ModifyBookingRequest
        {
            get;
            set;
        }

        /// <remarks/>
        public RequestRequestDetailsCancelBookingRequest CancelBookingRequest
        {
            get;
            set;
        }

        /// <remarks/>
        public RequestRequestDetailsSearchBookingRequest SearchBookingRequest
        {
            get
            {
                return this.searchBookingRequestField;
            }
            set
            {
                this.searchBookingRequestField = value;
            }
        }

        /// <remarks/>
        public RequestRequestDetailsAddBookingItemRequest AddBookingItemRequest
        {
            get
            {
                return this.addBookingItemRequestField;
            }
            set
            {
                this.addBookingItemRequestField = value;
            }
        }

        /// <remarks/>
        public object ModifyBookingItemRequest
        {
            get
            {
                return this.modifyBookingItemRequestField;
            }
            set
            {
                this.modifyBookingItemRequestField = value;
            }
        }

        /// <remarks/>
        public object CancelBookingItemRequest
        {
            get
            {
                return this.cancelBookingItemRequestField;
            }
            set
            {
                this.cancelBookingItemRequestField = value;
            }
        }

        /// <remarks/>
        public object SearchBookingItemRequest
        {
            get
            {
                return this.searchBookingItemRequestField;
            }
            set
            {
                this.searchBookingItemRequestField = value;
            }
        }

    }
}
